﻿namespace MemoryGame_Paulina
{
    partial class OknoGry
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DupCard8 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.DupCard7 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.DupCard6 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.DupCard5 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.DupCard4 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.DupCard3 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.DupCard2 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.DupCard1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.CardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsHolder
            // 
            this.CardsHolder.Controls.Add(this.DupCard8);
            this.CardsHolder.Controls.Add(this.Card8);
            this.CardsHolder.Controls.Add(this.DupCard7);
            this.CardsHolder.Controls.Add(this.Card7);
            this.CardsHolder.Controls.Add(this.DupCard6);
            this.CardsHolder.Controls.Add(this.Card6);
            this.CardsHolder.Controls.Add(this.DupCard5);
            this.CardsHolder.Controls.Add(this.Card5);
            this.CardsHolder.Controls.Add(this.DupCard4);
            this.CardsHolder.Controls.Add(this.Card4);
            this.CardsHolder.Controls.Add(this.DupCard3);
            this.CardsHolder.Controls.Add(this.Card3);
            this.CardsHolder.Controls.Add(this.DupCard2);
            this.CardsHolder.Controls.Add(this.Card2);
            this.CardsHolder.Controls.Add(this.DupCard1);
            this.CardsHolder.Controls.Add(this.Card1);
            this.CardsHolder.Location = new System.Drawing.Point(2, 3);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(707, 685);
            this.CardsHolder.TabIndex = 0;
            
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(715, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(83, 28);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Wynik:";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreCounter.Location = new System.Drawing.Point(804, 16);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(24, 28);
            this.ScoreCounter.TabIndex = 2;
            this.ScoreCounter.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(818, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(720, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(732, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zacznij za:";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(728, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(790, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(816, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "sec";
            // 
            // DupCard8
            // 
            this.DupCard8.Location = new System.Drawing.Point(531, 516);
            this.DupCard8.Name = "DupCard8";
            this.DupCard8.Size = new System.Drawing.Size(170, 165);
            this.DupCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard8.TabIndex = 15;
            this.DupCard8.TabStop = false;
            this.DupCard8.Tag = "8";
            this.DupCard8.Click += new System.EventHandler(this.DupCard8_Click);
            // 
            // Card8
            // 
            this.Card8.Location = new System.Drawing.Point(355, 516);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(170, 165);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 14;
            this.Card8.TabStop = false;
            this.Card8.Tag = "8";
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // DupCard7
            // 
            this.DupCard7.Location = new System.Drawing.Point(179, 516);
            this.DupCard7.Name = "DupCard7";
            this.DupCard7.Size = new System.Drawing.Size(170, 165);
            this.DupCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard7.TabIndex = 13;
            this.DupCard7.TabStop = false;
            this.DupCard7.Tag = "7";
            this.DupCard7.Click += new System.EventHandler(this.DupCard7_Click);
            // 
            // Card7
            // 
            this.Card7.Location = new System.Drawing.Point(3, 516);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(170, 165);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 12;
            this.Card7.TabStop = false;
            this.Card7.Tag = "7";
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // DupCard6
            // 
            this.DupCard6.Location = new System.Drawing.Point(531, 345);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(170, 165);
            this.DupCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard6.TabIndex = 11;
            this.DupCard6.TabStop = false;
            this.DupCard6.Tag = "6";
            this.DupCard6.Click += new System.EventHandler(this.DupCard6_Click);
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(355, 345);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(170, 165);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 10;
            this.Card6.TabStop = false;
            this.Card6.Tag = "6";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.Location = new System.Drawing.Point(179, 345);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(170, 165);
            this.DupCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard5.TabIndex = 9;
            this.DupCard5.TabStop = false;
            this.DupCard5.Tag = "5";
            this.DupCard5.Click += new System.EventHandler(this.DupCard5_Click);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(3, 345);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(170, 165);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 8;
            this.Card5.TabStop = false;
            this.Card5.Tag = "5";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.Location = new System.Drawing.Point(531, 174);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(170, 165);
            this.DupCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard4.TabIndex = 7;
            this.DupCard4.TabStop = false;
            this.DupCard4.Tag = "4";
            this.DupCard4.Click += new System.EventHandler(this.DupCard4_Click);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(355, 174);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(170, 165);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 6;
            this.Card4.TabStop = false;
            this.Card4.Tag = "4";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.Location = new System.Drawing.Point(179, 174);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(170, 165);
            this.DupCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard3.TabIndex = 5;
            this.DupCard3.TabStop = false;
            this.DupCard3.Tag = "3";
            this.DupCard3.Click += new System.EventHandler(this.DupCard3_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(3, 174);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(170, 165);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 4;
            this.Card3.TabStop = false;
            this.Card3.Tag = "3";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.Location = new System.Drawing.Point(531, 3);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(170, 165);
            this.DupCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard2.TabIndex = 3;
            this.DupCard2.TabStop = false;
            this.DupCard2.Tag = "2";
            this.DupCard2.Click += new System.EventHandler(this.DupCard2_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(355, 3);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(170, 165);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 2;
            this.Card2.TabStop = false;
            this.Card2.Tag = "2";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.Location = new System.Drawing.Point(179, 3);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(170, 165);
            this.DupCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard1.TabIndex = 1;
            this.DupCard1.TabStop = false;
            this.DupCard1.Tag = "1";
            this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(3, 3);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(170, 165);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // OknoGry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 691);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CardsHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OknoGry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoryGame";
            this.Load += new System.EventHandler(this.OknoGry_Load);
            this.CardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.PictureBox DupCard8;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox DupCard7;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox DupCard6;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox DupCard5;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox DupCard4;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox DupCard3;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox DupCard2;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox DupCard1;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

