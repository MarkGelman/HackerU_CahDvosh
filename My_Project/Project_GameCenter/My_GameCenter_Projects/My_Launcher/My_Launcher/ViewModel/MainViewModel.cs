using My_Launcher.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Launcher.ViewModel
{
    class MainViewModel
    {
        SlideShow files = new SlideShow();
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
