using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiPage_AllPageInList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Page> list_pages;
        int index = 0; //index of page
        Page currentPage;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            this.list_pages = new List<Page>();
            list_pages.Add(new Page1());
            list_pages.Add(new Page2());
            list_pages.Add(new Page3());

        }

        private void PrevPage_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.Content != null && index != 0)
            {
                index--;
                MyFrame.Content = list_pages[index];
            }
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.Content == null) MyFrame.Content = list_pages[index];
            else
                index++;
            if (index < list_pages.Count)
            {
                MyFrame.Content = list_pages[index];
            }
            else
                index = 0;
        }
    }
}
