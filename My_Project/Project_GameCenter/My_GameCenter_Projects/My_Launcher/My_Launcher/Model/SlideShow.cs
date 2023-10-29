using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Launcher.Model
{
    class SlideShow
    {
        public List<string> slides = new List<string>();
        public void  pathToImage()
        {

            // Задайте относительный путь к директории
            string relativePath = "относительный_путь_к_директории";

            // Преобразуйте относительный путь в абсолютный путь
            string absolutePath = Path.GetFullPath(relativePath);

            // Получите список файлов в указанной директории
            slides = Directory.GetFiles(absolutePath).ToList();

        }
    }
}
