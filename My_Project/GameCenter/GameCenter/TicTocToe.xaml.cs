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

namespace GameCenter
{
    
    public partial class TicTocToe : Page
    {
        bool turn = true; //true = x turn; false = o turn
        int turn_count = 0;
        public TicTocToe()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            b.Content = turn ? "X" : "O";

            

            turn = !turn;
            b.IsEnabled = false;

            checkForWinner();
                
        }

        private void checkForWinner()
        {
            bool isWinner = false;

            //Vertical cheks and event content of all buttons is empty
            if((A1.Content == A2.Content) &&(A2.Content == A3.Content) && (!A1.IsEnabled))
                isWinner = true;
            else if ((B1.Content == B2.Content) && (B2.Content == B3.Content) && (!B1.IsEnabled))
                isWinner = true;
            else if ((C1.Content == C2.Content) && (C2.Content == C3.Content) && (!C1.IsEnabled))
                isWinner = true;

            //dioganal cheks
            if(!B2.IsEnabled)
                if ((A1.Content == B2.Content) && (B2.Content == C3.Content))
                    isWinner = true;
                else if ((A3.Content == B2.Content) && (B2.Content == C1.Content))
                    isWinner = true;


            //Message about winner
            if(isWinner)
            {
                String winner = "";
                winner = turn? "O" : "X";

                MessageBox.Show(winner + "Wins!", "Yhoooooo!");
            }
   
        }
    }
}
