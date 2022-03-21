using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;

        bool player1Win = false;
        bool opponentWin = false;

        int player1score = 0;
        int opponentscore = 0;
        string opponentmarker;
        string opponent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;
                
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }
        private void btn_onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent=="Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn = false;
                turn_count++;
                
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");
                    
                    refresh();
                    turn_count = 0;

                }
                winner_algo();
            }
            else if(turn == false)
            {
                turn = true;
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }
        public void refresh()
        {
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
        }
        public void winner_algo()
        {

            if ((button11.Text == button12.Text) && (button12.Text == button13.Text) && (button11.Text != "") && (button12.Text != "") && (button13.Text != ""))
            {
                if (button11.Text == Markercombobox.Text)
                {

                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }

                refresh();


            }

            if ((button21.Text == button22.Text) && (button22.Text == button23.Text) && (button21.Text != "") && (button22.Text != "") && (button23.Text != ""))
            {
                if (button21.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();

            }

            if ((button31.Text == button32.Text) && (button32.Text == button33.Text) && (button31.Text != "") && (button32.Text != "") && (button33.Text != ""))
            {
                if (button31.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();
            }

            if ((button11.Text == button21.Text) && (button21.Text == button31.Text) && (button11.Text != "") && (button21.Text != "") && (button31.Text != ""))
            {
                if (button11.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();
            }

            if ((button12.Text == button22.Text) && (button22.Text == button32.Text) && (button12.Text != "") && (button22.Text != "") && (button32.Text != ""))
            {
                if (button12.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();
            }
            if ((button13.Text == button23.Text) && (button23.Text == button33.Text) && (button13.Text != "") && (button23.Text != "") && (button33.Text != ""))
            {
                if (button13.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();
            }
            if ((button11.Text == button22.Text) && (button22.Text == button33.Text) && (button11.Text != "") && (button22.Text != "") && (button33.Text != ""))
            {
                if (button11.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();
            }
            if ((button13.Text == button22.Text) && (button22.Text == button31.Text) && (button13.Text != "") && (button22.Text != "") && (button31.Text != ""))
            {
                if (button13.Text == Markercombobox.Text)
                {
                    MessageBox.Show("Player 1 wins!!!");
                    player1Win = true;

                }
                else
                {
                    MessageBox.Show("Opponent wins!!!");
                    opponentWin = true;
                }
                refresh();

            }
            
        }
        public void Computer()
        {
            Random ra = new Random();
            int num = ra.Next(1,9);
            if (num == 1 && button11.Text=="")
            {
                button11.Text = opponentmarker;
            }
            else if (num == 2 && button12.Text == "")
            {
                button12.Text = opponentmarker;
            }
            else if (num == 3 && button13.Text == "")
            {
                button13.Text = opponentmarker;
            }
            else if (num == 4 && button21.Text == "")
            {
                button21.Text = opponentmarker;
            }
            else if (num == 5 && button22.Text == "")
            {
                button22.Text = opponentmarker;
            }
            else if (num == 6 && button23.Text == "")
            {
                button23.Text = opponentmarker;
            }
            else if (num == 7 && button31.Text == "")
            {
                button31.Text = opponentmarker;
            }
            else if (num == 8 && button32.Text == "")
            {
                button32.Text = opponentmarker;
            }
            else if (num == 9 && button33.Text == "")
            {
                button33.Text = opponentmarker;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Movecombobox.Text == "Yes")
            {
                turn = true;
            }
            else if (Movecombobox.Text == "No")
            {
                turn = false;
            }
            if (Markercombobox.Text == "X")
            {
                opponentmarker = "O";
            }
            else if (Markercombobox.Text == "O")
            {
                opponentmarker = "X";
            }
            opponent = Opponentcombobox.Text;
            if (opponent == "Computer" && turn == true)
            {
                btn.Text = Markercombobox.Text;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }
                winner_algo();
                Computer();
                winner_algo();
            }


            if (opponentWin == true)
            {

                opponentscore++;
                OpponentLabel.Text = opponentscore.ToString();
                turn_count = 0;
                opponentWin = false;

            }
            else if (player1Win == true)
            {

                player1score++;
                Player1Label.Text = player1score.ToString();
                turn_count = 0;
                player1Win = false;
            }
        }
    }
}
