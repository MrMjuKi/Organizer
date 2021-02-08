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
    public partial class fWyszukajZdarzenieStand : Form
    {
        public fWyszukajZdarzenieStand(string nazwa, string godzRozp)
        {
            InitializeComponent();

            error(nazwa, godzRozp); //sprawdzanie wpisanego stringa

        }

        private void error(string nazwa1, string godz1)
        {

            //wyswietl wyszukane zdarzenie

            label2.Text = nazwa1;
            //labelTajniak.Text = godz1.ToString();

            label3.Text = godz1.ToString(); // ("dd.MM.yyyy HH:mm");

            this.Show();

        }

        private void buttonWiecej_Click(object sender, EventArgs e)
        {
            fWyswSzczegolyWydarzStand okno = new fWyswSzczegolyWydarzStand(label2.Text, label3.Text);
            
            //MessageBox.Show(label2.Text + label3.Text);
            okno.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(40, 20, 0, 0);
        }
    }
}
