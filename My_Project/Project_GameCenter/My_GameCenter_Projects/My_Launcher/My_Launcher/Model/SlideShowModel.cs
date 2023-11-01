using My_Launcher.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Launcher.Model
{
    class SlideShowModel
    {
        public string[] imageBackFiles;
        public string[] imageTopFiles;

        public SlideShowModel()
        {
            try
            {
                // Загрузить список файлов изображений
                imageBackFiles = Directory.GetFiles("View/res/Background", "*.png");
                imageTopFiles = Directory.GetFiles("View/Res /imageTopBackgroundFiles", "*.png");
                  
            }
            catch (Exception ex)
            {
                Show(ex.Message);
            }
        }
    }
}
