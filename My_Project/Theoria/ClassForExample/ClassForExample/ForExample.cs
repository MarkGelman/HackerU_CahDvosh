using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassForExample
{
    internal class ForExample
    {
    }

    class FileIOService
    {
        //нужно скачать библиотеку NuotonsonJson для того чтобы работать с JSON-файлами

        //создаём переменную для хранения пути к файлу данных
        private readonly string PATH;

        //создаём конструктор в который будем передавать путь к файлу JSON во время создания объекта класса
        public FileIOService(string path)
        {
            PATH = path;
        }

        //создаём метод который будет возвращать лист с данными полученными из файла JSON (или из базы данных)
        public BindingList<TypeOfData> LoadData()
        {
            //создаём переменную для хранения булевого значения существует ли файл JSON или нет
            var fileExists = File.Exists(PATH);

            //если файла нет, то мы его создаём и возвращаем созданный объект BindingList<TypeOfData>
            if (!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<TypeOfData>();
            }
            
            //
            using(var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConverter.DeserializeObject < BindingList<TypeofData>>(fileText);
            }

            return null;
        }

        //создаём метод который будет сохранять данные в файл JSON
        public void SaveData(BindingList<TypeOfData> typeOfDataDataList) 
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerelizeObject(typeOfDataDataList);
                writer.Write(output);
            }
        }
    }
}
