using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame_Paulina
{
    public partial class OknoGry : Form
    {
        //Zmienne
        int score = 0; //Wynik
        Random Location = new Random(); //Wybiera przypadkową wartość X i Y i przydziela nową lokalizacje każdej karcie
        List<int> X = new List<int>(); //wartosc X lub kazdego picturebox
        List<int> Y = new List<int>(); //wartosc Y lub kazdego picturebox
        bool again = false; //Zagraj ponownie lub nie

        public OknoGry()
        {
            InitializeComponent();
        }

        private void OknoGry_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            Card1.Image = Properties.Resources._01;
            DupCard1.Image = Properties.Resources._01;
            Card2.Image = Properties.Resources._02;
            DupCard2.Image = Properties.Resources._02;
            Card3.Image = Properties.Resources._03;
            DupCard3.Image = Properties.Resources._03;
            Card4.Image = Properties.Resources._04;
            DupCard4.Image = Properties.Resources._04;
            Card5.Image = Properties.Resources._05;
            DupCard5.Image = Properties.Resources._05;
            Card6.Image = Properties.Resources._06;
            DupCard6.Image = Properties.Resources._06;
            Card7.Image = Properties.Resources._07;
            DupCard7.Image = Properties.Resources._07;
            Card8.Image = Properties.Resources._082;
            DupCard8.Image = Properties.Resources._082;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Image = Properties.Resources.tlo;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }
    }
}
