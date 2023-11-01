using My_Launcher.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace My_Launcher.ViewModel
{
    public class SlideShowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SlideShowModel> images;
        private SlideShowModel _slide; 

        private int currentIndex;
        private DispatcherTimer timer;

        public SlideShowViewModel()
        {
            _slide = new SlideShowModel();

            foreach (string topFile in _slide.imageTopFiles) 
                foreach(string backFile in _slide.imageBackFiles)
                {
                    if(topFile == backFile)

                }

            // Настройка таймера для автоматической смены слайдов
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5); // Интервал смены слайдов (5 секунд в данном случае)
            timer.Tick += (sender, e) => NextSlide();
            timer.Start();
        }

        public ObservableCollection<ImageModel> Images
        {
            get { return images; }
            set
            {
                images = value;
                OnPropertyChanged(nameof(Images));
            }
        }

        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                currentIndex = value;
                OnPropertyChanged(nameof(CurrentIndex));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Метод для переключения к следующему слайду
        public void NextSlide()
        {
            if (CurrentIndex < Images.Count - 1)
            {
                CurrentIndex++;
            }
            else
            {
                CurrentIndex = 0; // Вернуться к первому слайду, если достигнут конец списка
            }
        }
    }

}
