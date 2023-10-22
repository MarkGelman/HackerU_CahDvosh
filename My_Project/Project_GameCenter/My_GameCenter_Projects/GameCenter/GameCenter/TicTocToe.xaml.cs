using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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


namespace GameCenter
{
    
    public partial class TicTocToe : Page
    {
        TicTocToeLogic ticTocToeLogic = new TicTocToeLogic();
        private int col;
        private int row;  

        public TicTocToe()
        {
            InitializeComponent();
        }

        private void PlayerClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            button.Content = ticTocToeLogic.CurrentPlayer;
            button.IsEnabled = false;

            col = Grid.GetColumn(button);
            row = Grid.GetRow(button);
            
            if (ticTocToeLogic.CheckForWinner(col,row))
            {
               foreach(var control in gridBoard.Children)
                {
                    Button button1 = control as Button;
                    button.IsEnabled = true;
                }
                   
                        
               Announcement(true);
            }
            else
            {
                if (ticTocToeLogic.IsBoardFull())
                    Announcement(false);
                else
                    ticTocToeLogic.SetNextPlayer();
            }
        }


        private void Announcement(bool winner)
        {
            winnerTxt.Text = winner ? $"{ticTocToeLogic.CurrentPlayer} WINS!!!" : "TECO!!!";
            winnerTxt.Visibility = Visibility.Visible;

        }


        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach(var control in gridBoard.Children)
            {
                Button button = control as Button;
                button.IsEnabled = true;
                button.Content = String.Empty; 
               
            }

            ticTocToeLogic = new TicTocToeLogic();
            winnerTxt.Visibility = Visibility.Collapsed;

        }
    }
}
