using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace GameCenter
{
    class TicTocToeLogic
    {
        public string CurrentPlayer { get; set; } = "X";
        private const string _X ="X";
        private const string _O ="O";
        private string[,] _board = new string [3, 3];
        private int _countContent = 0;
        

        public void SetNextPlayer()
        {
            CurrentPlayer = CurrentPlayer == "X" ? "O" : "X";
        }

        public bool CheckForWinner(int col,int row)
        {
            _board[col, row] = CurrentPlayer;

            for (int i = 0; i < 3; i++)
            {
                if (_board[0, i] == CurrentPlayer && _board[1, i] == CurrentPlayer && _board[2, i] == CurrentPlayer)
                    return true;
            }

            for (int i = 0; i < 3; i++)
                if (_board[i, 0] == CurrentPlayer && _board[i, 1] == CurrentPlayer && _board[i, 2] == CurrentPlayer)
                    return true;

            if (_board[0, 0] == CurrentPlayer && _board[1, 1] == CurrentPlayer && _board[2, 2] == CurrentPlayer)
                return true;

            else if (_board[0, 2] == CurrentPlayer && _board[1, 1] == CurrentPlayer && _board[2, 0] == CurrentPlayer)
                return true;

            return false;

        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (_board[i, j] == null)
                        return false;
            return true;

        }
    }


}
