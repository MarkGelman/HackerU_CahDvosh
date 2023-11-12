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

namespace tic_tak_too
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char _currentPlayer = 'X';
        private char[,] _board = new char[3,3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // if the button content is empty --> show the X or 0 in the button && update the matrix
            Button btn = (Button)sender;
            if(btn.Content == null)
            {
                btn.Content = _currentPlayer;
                int row = Grid.GetRow(btn);
                int col = Grid.GetColumn(btn);
                _board[row, col] = _currentPlayer;

                // change the player from 1 to 2 or vice versa
                _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';

            }







            // check if someone win -> show message -> reset the board 
            // check if the board is full  -> show message -> reset the board 
        }
    }
}
