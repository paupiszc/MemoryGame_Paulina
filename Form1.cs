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
            foreach(PictureBox picture in CardsHolder.Controls)
            {
                picture.Image = Properties.Resources._08;
            }
        }
    }
}
