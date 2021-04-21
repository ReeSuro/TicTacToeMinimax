using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeMinimax
{
    public partial class Form1 : Form
    {
        TicTacToeGame Game;
        IPlayer Player1;
        IPlayer Player2;
        bool isPlayer1Turn;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deactivate game board
            Tile1.Enabled = false;
            Tile2.Enabled = false;
            Tile3.Enabled = false;
            Tile4.Enabled = false;
            Tile5.Enabled = false;
            Tile6.Enabled = false;
            Tile7.Enabled = false;
            Tile8.Enabled = false;
            Tile9.Enabled = false;

            //Set dropdown values
            Player1Combo.Enabled = true;
            Player1Combo.Text = "--Select--";
            Player1Combo.Items.Add("Human");
            Player1Combo.Items.Add("Full Tree Search");
            Player1Combo.Items.Add("Depth Search w/ Eval");

            Player2Combo.Enabled = true;
            Player2Combo.Text = "--Select--";
            Player2Combo.Items.Add("Human");
            Player2Combo.Items.Add("Full Tree Search");
            Player2Combo.Items.Add("Depth Search w/ Eval");

            Player1NumericSelect.Enabled = false;
            Player2NumericSelect.Enabled = false;
            MultipleGamesNumericSelect.Enabled = false;

            ResetButton.Enabled = false;
            StartButton.Enabled = true;
            MultipleGamesCheck.Checked = false;
            isPlayer1Turn = true;
        }

        private void Tile8_Click(object sender, EventArgs e)
        {
            Tile8.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[2, 1] = 'X';
                Tile8.Text = "X";
            }
            else
            {
                Game._GameBoard[2, 1] = 'O';
                Tile8.Text = "O";
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0) {
                EndGame(state);
            }

        }

        private void Tile2_Click(object sender, EventArgs e)
        {
            Tile2.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 1] = 'X';
                Tile2.Text = "X";
            }
            else
            {
                Game._GameBoard[0, 1] = 'O';
                Tile2.Text = "O";
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile3_Click(object sender, EventArgs e)
        {
            Tile3.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 2] = 'X';
                Tile3.Text = "X";
            }
            else
            {
                Game._GameBoard[0, 2] = 'O';
                Tile3.Text = "O";
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile6_Click(object sender, EventArgs e)
        {
            Tile6.Enabled = false;
            if (isPlayer1Turn)
            {
                Tile6.Text = "X";
                Game._GameBoard[1, 2] = 'X';
            }
            else
            {
                Tile6.Text = "O";
                Game._GameBoard[1, 2] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile5_Click(object sender, EventArgs e)
        {
            Tile5.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[1, 1] = 'X';
                Tile5.Text = "X";
            }
            else
            {
                Game._GameBoard[1, 1] = 'O';
                Tile5.Text = "O";
            }

            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile4_Click(object sender, EventArgs e)
        {
            Tile4.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[1, 0] = 'X';
                Tile4.Text = "X";
            }
            else
            {
                Tile4.Text = "O";
                Game._GameBoard[1, 0] = 'O';
            }

            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile7_Click(object sender, EventArgs e)
        {
            Tile7.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[2, 0] = 'X';
                Tile7.Text = "X";
            }
            else
            {
                Game._GameBoard[2, 0] = 'O';
                Tile7.Text = "O";
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile1_Click(object sender, EventArgs e)
        {
            Tile1.Enabled = false;
            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 0] = 'X';
                Tile1.Text = "X";
            }
            else
            {
                Tile1.Text = "O";
                Game._GameBoard[0, 0] = 'O';
            }

            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private void Tile9_Click(object sender, EventArgs e)
        {
            Tile9.Enabled = false;
            if (isPlayer1Turn)
            {
                Tile9.Text = "X";
                Game._GameBoard[2, 2] = 'X';
            }
            else
            {
                Tile9.Text = "O";
                Game._GameBoard[2, 2] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            int state = Game.IsGameFinished();
            if (state != 0)
            {
                EndGame(state);
            }
        }

        private bool FormStartReady() {

            bool state = true;

            if (Player1Combo.SelectedIndex == -1)
                state = false;
            if (Player2Combo.SelectedIndex == -1)
                state = false;

            if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Depth Search w/ Eval") 
            {
                if (Player1NumericSelect.Value < 1)
                    state = false;
            }

            if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Depth Search w/ Eval")
            {
                if (Player2NumericSelect.Value < 1)
                    state = false;
            }

            return state;

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (FormStartReady()) {

                StartGame();
            }
        }
        private void StartGame() {

            //Disable buttons
            Tile1.Enabled = true;
            Tile2.Enabled = true;
            Tile3.Enabled = true;
            Tile4.Enabled = true;
            Tile5.Enabled = true;
            Tile6.Enabled = true;
            Tile7.Enabled = true;
            Tile8.Enabled = true;
            Tile9.Enabled = true;

            StartButton.Enabled = false;
            ResetButton.Enabled = true;

            Player1Combo.Enabled = false;
            Player2Combo.Enabled = false;

            Player1NumericSelect.Enabled = false;
            Player2NumericSelect.Enabled = false;

            MultipleGamesCheck.Enabled = false;
            MultipleGamesNumericSelect.Enabled = false;

            //Create player objects
            if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Human")
            {
                Player1 = new HumanPlayer(true);
            }

            if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Human")
            {
                Player2 = new HumanPlayer(true);
            }

            Game = new TicTacToeGame(Player1, Player2);

        }


        private void EndGame(int state) {

            //Deactivate game board
            Tile1.Enabled = false;
            Tile2.Enabled = false;
            Tile3.Enabled = false;
            Tile4.Enabled = false;
            Tile5.Enabled = false;
            Tile6.Enabled = false;
            Tile7.Enabled = false;
            Tile8.Enabled = false;
            Tile9.Enabled = false;
        }


      
    }

}
