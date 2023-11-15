using LogIn_SigIn.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace LogIn_SigIn.Controllers
{
    class UserController
    {
        List<User> users = new List<User>();
        public List<User> GetUsers()
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader("models/db/users.json"));
            //важная строка без неё при чтении файла будет выдаваться ошибка
            reader.SupportMultipleContent = true;
            //чтение из JSON-файла. Если reader перестаёт читать, то автоматически прекращается цикл
            try
            {
                
                while (true)
                {
                    //пока reader читает он возвращает true. Как только доходит до конца файла он выдаёт false и тогда мы выходим из цикла
                    if (!reader.Read()) break;

                    Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                    //данные из JSON-файла парсятся в соответствующие поля объекта
                    User user = serializer.Deserialize<User>(reader);
                    users.Add(user);

                }
            }
            catch 
            {
                throw;
                   
            }
            return new List<User>();
        }



    }
}
