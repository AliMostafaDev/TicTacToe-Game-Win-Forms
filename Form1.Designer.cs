namespace TicTacToe_Game_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb1.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(431, 133);
            this.pb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(131, 81);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Tag = "0";
            this.pb1.Click += new System.EventHandler(this.pbClick);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb3.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(835, 133);
            this.pb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(131, 81);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.Tag = "0";
            this.pb3.Click += new System.EventHandler(this.pbClick);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb2.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(636, 133);
            this.pb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(131, 81);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Tag = "0";
            this.pb2.Click += new System.EventHandler(this.pbClick);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb5.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(636, 267);
            this.pb5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(131, 81);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            this.pb5.Tag = "0";
            this.pb5.Click += new System.EventHandler(this.pbClick);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb6.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(835, 267);
            this.pb6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(131, 81);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 4;
            this.pb6.TabStop = false;
            this.pb6.Tag = "0";
            this.pb6.Click += new System.EventHandler(this.pbClick);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb4.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(431, 267);
            this.pb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(131, 81);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Tag = "0";
            this.pb4.Click += new System.EventHandler(this.pbClick);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb8.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(636, 393);
            this.pb8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(131, 81);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 8;
            this.pb8.TabStop = false;
            this.pb8.Tag = "0";
            this.pb8.Click += new System.EventHandler(this.pbClick);
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb9.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(835, 393);
            this.pb9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(131, 81);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 7;
            this.pb9.TabStop = false;
            this.pb9.Tag = "0";
            this.pb9.Click += new System.EventHandler(this.pbClick);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb7.Image = global::TicTacToe_Game_Project.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(431, 393);
            this.pb7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(131, 81);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 6;
            this.pb7.TabStop = false;
            this.pb7.Tag = "0";
            this.pb7.Click += new System.EventHandler(this.pbClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(164, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(113, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Winner";
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Black;
            this.lblTurn.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(85, 196);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(272, 48);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(49, 302);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(233, 46);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(93, 367);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(212, 58);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
    }
}

