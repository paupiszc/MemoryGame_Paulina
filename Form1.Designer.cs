namespace MemoryGame_Paulina
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
            this.CardsHolder.Location = new System.Drawing.Point(12, 6);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(445, 446);
            this.CardsHolder.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel.Location = new System.Drawing.Point(475, 19);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(73, 25);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Wynik:";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreCounter.Location = new System.Drawing.Point(554, 19);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(22, 25);
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
            this.label1.Location = new System.Drawing.Point(515, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "5";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DupCard8
            // 
            this.DupCard8.Location = new System.Drawing.Point(331, 331);
            this.DupCard8.Name = "DupCard8";
            this.DupCard8.Size = new System.Drawing.Size(100, 100);
            this.DupCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard8.TabIndex = 15;
            this.DupCard8.TabStop = false;
            this.DupCard8.Click += new System.EventHandler(this.DupCard8_Click);
            // 
            // Card8
            // 
            this.Card8.Location = new System.Drawing.Point(225, 331);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(100, 100);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 14;
            this.Card8.TabStop = false;
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // DupCard7
            // 
            this.DupCard7.Location = new System.Drawing.Point(119, 331);
            this.DupCard7.Name = "DupCard7";
            this.DupCard7.Size = new System.Drawing.Size(100, 100);
            this.DupCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard7.TabIndex = 13;
            this.DupCard7.TabStop = false;
            this.DupCard7.Click += new System.EventHandler(this.DupCard7_Click);
            // 
            // Card7
            // 
            this.Card7.Location = new System.Drawing.Point(13, 331);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(100, 100);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 12;
            this.Card7.TabStop = false;
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // DupCard6
            // 
            this.DupCard6.Location = new System.Drawing.Point(331, 225);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(100, 100);
            this.DupCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard6.TabIndex = 11;
            this.DupCard6.TabStop = false;
            this.DupCard6.Click += new System.EventHandler(this.DupCard6_Click);
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(225, 225);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(100, 100);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 10;
            this.Card6.TabStop = false;
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.Location = new System.Drawing.Point(119, 225);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(100, 100);
            this.DupCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard5.TabIndex = 9;
            this.DupCard5.TabStop = false;
            this.DupCard5.Click += new System.EventHandler(this.DupCard5_Click);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(13, 225);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(100, 100);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 8;
            this.Card5.TabStop = false;
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.Location = new System.Drawing.Point(331, 119);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(100, 100);
            this.DupCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard4.TabIndex = 7;
            this.DupCard4.TabStop = false;
            this.DupCard4.Click += new System.EventHandler(this.DupCard4_Click);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(225, 119);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(100, 100);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 6;
            this.Card4.TabStop = false;
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.Location = new System.Drawing.Point(119, 119);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(100, 100);
            this.DupCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard3.TabIndex = 5;
            this.DupCard3.TabStop = false;
            this.DupCard3.Click += new System.EventHandler(this.DupCard3_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(13, 119);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(100, 100);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 4;
            this.Card3.TabStop = false;
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.Location = new System.Drawing.Point(331, 13);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(100, 100);
            this.DupCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard2.TabIndex = 3;
            this.DupCard2.TabStop = false;
            this.DupCard2.Click += new System.EventHandler(this.DupCard2_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(225, 13);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(100, 100);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 2;
            this.Card2.TabStop = false;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.Location = new System.Drawing.Point(119, 13);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(100, 100);
            this.DupCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard1.TabIndex = 1;
            this.DupCard1.TabStop = false;
            this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(13, 13);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(100, 100);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // OknoGry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 464);
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
    }
}

