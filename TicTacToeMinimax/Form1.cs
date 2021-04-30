using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        Task GameTask;
        CancellationTokenSource tokenSource;

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
            Player1NumericSelect.Value = 1;
            Player2NumericSelect.Value = 1;
            MultipleGamesNumericSelect.Enabled = false;

            StartButton.Enabled = true;
            MultipleGamesCheck.Checked = false;
            isPlayer1Turn = true;

            ResultLabel.Visible = false;
            Player1Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Player2Combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #region Button Click Events
        private void Tile8_Click(object sender, EventArgs e)
        {
            Tile8.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[2, 1] = 'X'; 
            }
            else
            {
                Game._GameBoard[2, 1] = 'O';
               
            }
            //Update the turn flags
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile2_Click(object sender, EventArgs e)
        {
            Tile2.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 1] = 'X';
            }
            else
            {
                Game._GameBoard[0, 1] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile3_Click(object sender, EventArgs e)
        {
            Tile3.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 2] = 'X';
              
            }
            else
            {
                Game._GameBoard[0, 2] = 'O';
              
            }
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile6_Click(object sender, EventArgs e)
        {
            Tile6.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[1, 2] = 'X';
            }
            else
            {               
                Game._GameBoard[1, 2] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile5_Click(object sender, EventArgs e)
        {
            Tile5.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[1, 1] = 'X';
            }
            else
            {
                Game._GameBoard[1, 1] = 'O';
            }

            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile4_Click(object sender, EventArgs e)
        {
            Tile4.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[1, 0] = 'X';
            }
            else
            {
                Game._GameBoard[1, 0] = 'O';
            }

            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile7_Click(object sender, EventArgs e)
        {
            Tile7.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[2, 0] = 'X';
            }
            else
            {
                Game._GameBoard[2, 0] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile1_Click(object sender, EventArgs e)
        {
            Tile1.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;

            if (isPlayer1Turn)
            {
                Game._GameBoard[0, 0] = 'X'; 
            }
            else
            {
                Game._GameBoard[0, 0] = 'O';
            }

            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }

        private void Tile9_Click(object sender, EventArgs e)
        {
            Tile9.Enabled = false;
            isPlayer1Turn = Game.isPlayer1Turn;
            if (isPlayer1Turn)
            {
                Game._GameBoard[2, 2] = 'X';
            }
            else
            {     
                Game._GameBoard[2, 2] = 'O';
            }
            isPlayer1Turn = !isPlayer1Turn;
            Game.isPlayer1Turn = isPlayer1Turn;
        }
        #endregion
        private bool FormStartReady() {

            bool state = true;

            if (Player1Combo.SelectedIndex == -1)
                return false;
            if (Player2Combo.SelectedIndex == -1)
                return false;

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

            if(MultipleGamesCheck.Checked == true)
                if (Player2NumericSelect.Value < 1)
                    state = false;

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

            StartButton.Enabled = false;
            ResetButton.Enabled = true;

            Player1Combo.Enabled = false;
            Player2Combo.Enabled = false;

            Player1NumericSelect.Enabled = false;
            Player2NumericSelect.Enabled = false;

            MultipleGamesCheck.Enabled = false;
            MultipleGamesNumericSelect.Enabled = false;
            isPlayer1Turn = true;

            //Create player objects
            if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Human")
            {
                Player1 = new HumanPlayer(true);
                Tile1.Enabled = true;
                Tile2.Enabled = true;
                Tile3.Enabled = true;
                Tile4.Enabled = true;
                Tile5.Enabled = true;
                Tile6.Enabled = true;
                Tile7.Enabled = true;
                Tile8.Enabled = true;
                Tile9.Enabled = true;
            }
            else if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Full Tree Search") 
            {
                Player1 = new FullTreePlayer(true);
            }
            else if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Depth Search w/ Eval")
            {
                //Get the required depth
                Player1 = new DepthSearchPlayer(true, (int)Player1NumericSelect.Value);
            }

            if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Human")
            {
                Player2 = new HumanPlayer(false);
            }
            else if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Full Tree Search")
            {
                Player2 = new FullTreePlayer(false);
            }
            else if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Depth Search w/ Eval")
            {
                //Get the required depth
                Player2 = new DepthSearchPlayer(false, (int)Player2NumericSelect.Value);
            }
            //Create cancellation tokens in case game is reset
            tokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = tokenSource.Token;
            //Progress object handles the updating of GUI elements
            Progress<int> progress = new Progress<int>(UpdateGame);
            Game = new TicTacToeGame(Player1, Player2, progress, cancelToken);
           
                
            //Start the game thread running
            GameTask = new Task(Game.Run, cancelToken);
            GameTask.Start();
        }

        public void UpdateGame(int state) {

            //Update the GUI Elements
            char[,] board = Game._GameBoard;

            Tile1.Text = board[0, 0].ToString();
            Tile2.Text = board[0, 1].ToString();
            Tile3.Text = board[0, 2].ToString();
            Tile4.Text = board[1, 0].ToString();
            Tile5.Text = board[1, 1].ToString();
            Tile6.Text = board[1, 2].ToString();
            Tile7.Text = board[2, 0].ToString();
            Tile8.Text = board[2, 1].ToString();
            Tile9.Text = board[2, 2].ToString();
            //Check if the game is finished
            if (state != 0) {
                EndGame(state);
            }
            if (!Game.isPlayer1Turn)
            {
                if (Player1.GetType().Name == "HumanPlayer")
                {
                    DisablePlayedButtons();
                }
                else
                {
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
            else {

                if (Player2.GetType().Name == "HumanPlayer")
                {
                    DisablePlayedButtons();
                }
                else
                {
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

        private void EndGame(int state) {

            //Terminate game thread 
            tokenSource.Cancel();
            tokenSource.Dispose();

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

            //Display the game result
            ResultLabel.Visible = true;
            if (state == 1)
            {
                ResultLabel.Text = "Player 1 Wins!";
            }
            else if (state == 2) {
               
                ResultLabel.Text = "Player 2 Wins!";
            }
            else if (state == 3)
            {
                ResultLabel.Text = "Draw!";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Enable Start button
            StartButton.Enabled = true;
            //Stop game running
            if (GameTask != null && !GameTask.IsCompleted) {

                tokenSource.Cancel();
                tokenSource.Dispose();
            }

            //Reset the GUI elements
            Tile1.Text = " ";
            Tile2.Text = " ";
            Tile3.Text = " ";
            Tile4.Text = " ";
            Tile5.Text = " ";
            Tile6.Text = " ";
            Tile7.Text = " ";
            Tile8.Text = " ";
            Tile9.Text = " ";
            Tile1.Enabled = false;
            Tile2.Enabled = false;
            Tile3.Enabled = false;
            Tile4.Enabled = false;
            Tile5.Enabled = false;
            Tile6.Enabled = false;
            Tile7.Enabled = false;
            Tile8.Enabled = false;
            Tile9.Enabled = false;

            ResultLabel.Visible = false;
            Player1Combo.SelectedIndex = 0;
            Player2Combo.SelectedIndex = 0;
            Player1Combo.Enabled = true;
            Player2Combo.Enabled = true;
            Player1NumericSelect.Enabled = false;
            Player2NumericSelect.Enabled = false;
            Player1NumericSelect.Value = 0;
            Player2NumericSelect.Value = 0;
            MultipleGamesNumericSelect.Enabled = false;
            MultipleGamesNumericSelect.Value = 0;
            ResetButton.Enabled = false;
            MultipleGamesCheck.Checked = false;
        }

        private void Player1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {   //enable number when selected
            if (Player1Combo.SelectedIndex != -1)
            {
                if ((string)Player1Combo.Items[Player1Combo.SelectedIndex] == "Depth Search w/ Eval")
                {
                    Player1NumericSelect.Enabled = true;
                }
                else
                {
                    Player1NumericSelect.Enabled = false;
                }
            }
        }

        private void Player2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable number when selected
            if (Player2Combo.SelectedIndex != -1)
            {
                if ((string)Player2Combo.Items[Player2Combo.SelectedIndex] == "Depth Search w/ Eval")
                {
                    Player2NumericSelect.Enabled = true;
                }
                else
                {
                    Player2NumericSelect.Enabled = false;
                }
            }
        }

        private void MultipleGamesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MultipleGamesCheck.Checked == true)
            {
                MultipleGamesNumericSelect.Enabled = true;
            }
            else 
            {
                MultipleGamesNumericSelect.Enabled = false;
            }
        }

        public void DisablePlayedButtons() {
            //Not good 
            if (Tile1.Text == " ")
                Tile1.Enabled = true;
            else
                Tile1.Enabled = false;
            if (Tile2.Text == " ")
                Tile2.Enabled = true;
            else
                Tile2.Enabled = false;
            if (Tile3.Text == " ")
                Tile3.Enabled = true;
            else
                Tile3.Enabled = false;
            if (Tile4.Text == " ")
                Tile4.Enabled = true;
            else
                Tile4.Enabled = false;
            if (Tile5.Text == " ")
                Tile5.Enabled = true;
            else
                Tile5.Enabled = false;
            if (Tile6.Text == " ")
                Tile6.Enabled = true;
            else
                Tile6.Enabled = false;
            if (Tile7.Text == " ")
                Tile7.Enabled = true;
            else
                Tile7.Enabled = false;
            if (Tile8.Text == " ")
                Tile8.Enabled = true;
            else
                Tile8.Enabled = false;
            if (Tile9.Text == " ")
                Tile9.Enabled = true;
            else
                Tile9.Enabled = false;
        }

        private void Player1NumericSelect_ValueChanged(object sender, EventArgs e)
        {
            if (Player1NumericSelect.Value > 9)
                Player1NumericSelect.Value = 9;

            if (Player1NumericSelect.Value < 1)
                Player1NumericSelect.Value = 1;
        }

        private void Player2NumericSelect_ValueChanged(object sender, EventArgs e)
        {
            if (Player2NumericSelect.Value > 9)
                Player2NumericSelect.Value = 9;

            if (Player2NumericSelect.Value < 1)
                Player2NumericSelect.Value = 1;
        }
    }


}
