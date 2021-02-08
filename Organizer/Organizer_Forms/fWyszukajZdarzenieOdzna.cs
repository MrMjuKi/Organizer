using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer_Forms
{
    public partial class fWyszukajZdarzenieOdzna : Form
    {
        public fWyszukajZdarzenieOdzna(string nazwa, bool czyWyk, string data)
        {
            InitializeComponent();

            error(nazwa, czyWyk, data); //sprawdzanie wpisanego stringa

        }

        private void error(string nazwa, bool czyWyk, string data)
        {


            label2.Text = nazwa;
            label3.Text = data;
            if (!czyWyk) //zamiana false na nie i true na tak
            {
                label4.Text = "Nie";
            }
            else
                label4.Text = "Tak";

            this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(40, 20, 0, 0);
        }
    }
}
