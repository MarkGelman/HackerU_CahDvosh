using My_Launcher.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Launcher.ViewModel
{
    class MainViewModel:INotifyPropertyChanged
    {
        string _pathToImage = "";
        SlideShow files = new SlideShow();

        public event PropertyChangedEventHandler? PropertyChanged;

        public void SlideShow()
        {
            while(true)
            {
                foreach(var slide in files.slides)
                {

                }
            }

        }
    }
}
