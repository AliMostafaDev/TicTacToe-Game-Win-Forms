using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_Game_Project.Properties;

namespace TicTacToe_Game_Project
{
    public partial class Form1 : Form
    {
        private  int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Image = Resources.question_mark_96;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 600, 100, 600, 400);
            e.Graphics.DrawLine(Pen, 450, 100, 450, 400);
            e.Graphics.DrawLine(Pen, 300, 200, 750, 200);
            e.Graphics.DrawLine(Pen, 300, 300, 750, 300);

        }

        void Resetimages()
        {
            pb1.Image = Resources.question_mark_96;
            pb2.Image = Resources.question_mark_96;
            pb3.Image = Resources.question_mark_96;
            pb4.Image = Resources.question_mark_96;
            pb5.Image = Resources.question_mark_96;
            pb6.Image = Resources.question_mark_96;
            pb7.Image = Resources.question_mark_96;
            pb8.Image = Resources.question_mark_96;
            pb9.Image = Resources.question_mark_96;

            pb1.BackColor = Color.Transparent;
            pb2.BackColor = Color.Transparent;
            pb3.BackColor = Color.Transparent;
            pb4.BackColor = Color.Transparent;
            pb5.BackColor = Color.Transparent;
            pb6.BackColor = Color.Transparent;
            pb7.BackColor = Color.Transparent;
            pb8.BackColor = Color.Transparent;
            pb9.BackColor = Color.Transparent;

            pb1.Tag = 0;
            pb2.Tag = 0;
            pb3.Tag = 0;
            pb4.Tag = 0;
            pb5.Tag = 0;
            pb6.Tag = 0;
            pb7.Tag = 0;
            pb8.Tag = 0;
            pb9.Tag = 0;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player 1";

            Resetimages();
            EnableImages();

            btnRestart.BackColor = Color.Black;
        }

        void StopGame()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;

            btnRestart.BackColor = Color.Blue;
        }

        bool checkWinner()
        {
            if (pb1.Tag.ToString() == "1" &&  pb2.Tag.ToString() == "1" && pb3.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Yellow;
                pb2.BackColor = Color.Yellow;
                pb3.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return true;
            }
            if (pb1.Tag.ToString() == "2" && pb2.Tag.ToString() == "2" && pb3.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Yellow;
                pb2.BackColor = Color.Yellow;
                pb3.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb1.Tag.ToString() == "1" && pb4.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Yellow;
                pb4.BackColor = Color.Yellow;
                pb7.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb1.Tag.ToString() == "2" && pb4.Tag.ToString() == "2" && pb7.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Yellow;
                pb4.BackColor = Color.Yellow;
                pb7.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb7.Tag.ToString() == "1" && pb8.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb7.BackColor = Color.Yellow;
                pb8.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb7.Tag.ToString() == "2" && pb8.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb7.BackColor = Color.Yellow;
                pb8.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb3.Tag.ToString() == "1" && pb6.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb3.BackColor = Color.Yellow;
                pb6.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb3.Tag.ToString() == "2" && pb6.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb3.BackColor = Color.Yellow;
                pb6.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb1.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb9.Tag.ToString() == "1")
            {
                pb1.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb1.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb9.Tag.ToString() == "2")
            {
                pb1.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb9.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb3.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb7.Tag.ToString() == "1")
            {
                pb3.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb7.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb3.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb7.Tag.ToString() == "2")
            {
                pb3.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb7.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb2.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb8.Tag.ToString() == "1")
            {
                pb2.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb8.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb2.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb8.Tag.ToString() == "2")
            {
                pb2.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb8.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            if (pb4.Tag.ToString() == "1" && pb5.Tag.ToString() == "1" && pb6.Tag.ToString() == "1")
            {
                pb4.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb6.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player1";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (pb4.Tag.ToString() == "2" && pb5.Tag.ToString() == "2" && pb6.Tag.ToString() == "2")
            {
                pb4.BackColor = Color.Yellow;
                pb5.BackColor = Color.Yellow;
                pb6.BackColor = Color.Yellow;

                lblTurn.Text = "Game Over";
                lblWinner.Text = "Player2";

                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;

        }

        void ChangeImage(PictureBox pb)
        {
            if (pb.Tag.ToString() != "0")
            {
                MessageBox.Show("Choice Invalid", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblTurn.Text == "Player 1")
            {
                pb.Image = Resources.X;
                pb.Tag = 1;
            }
            else
            {
                pb.Image = Resources.O;
                pb.Tag = 2;
            }


            counter++;

            if (checkWinner())
                StopGame();
            else if (checkEnd())
                StopGame();
            else
                UpdateTurn();
        }

        bool checkEnd()
        {
            if (counter == 9)
            {
                lblTurn.Text = "Game Over";
                lblWinner.Text = "Draw";
                MessageBox.Show("GameOver (DRAW)", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        void EnableImages()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;
        }

        void UpdateTurn()
        {
            if (lblTurn.Text == "Player 1")
                lblTurn.Text = "Player 2";
            else
                lblTurn.Text = "Player 1";
        }

        private void pbClick(object sender, EventArgs e)
        {
            ChangeImage((PictureBox) sender);
        }


        
    }
}
