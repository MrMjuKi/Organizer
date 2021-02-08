using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Organizer_Forms
{
    public partial class fDodajUczestnika : Form
    {
        string connectionString = @"server=localhost;user id=root;database=Organizer";
        int ID_wspoluczestnika = 0;
        public fDodajUczestnika()
        {
            InitializeComponent();
        }

        private void fDodajUczestnika_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 20, 0, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bDodaj_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand dodaj = new MySqlCommand("DodajUczestnika", mysqlCon);
                dodaj.CommandType = CommandType.StoredProcedure;
                dodaj.Parameters.AddWithValue("_ID_wspoluczestnika", ID_wspoluczestnika);
                dodaj.Parameters.AddWithValue("_imie", txtImie.Text.Trim());
               // dodaj.Parameters.AddWithValue("_nazwisko", txtNazwisko.Text.Trim());
                dodaj.Parameters.AddWithValue("_relacja", txtRelacja.Text.Trim());
                dodaj.Parameters.AddWithValue("_data_urodzenia", dtpData_ur.Value.Date);
                dodaj.Parameters.AddWithValue("_nr_telefonu", txtNr_tel.Text.Trim());
                if (dodaj.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dodałeś nowego uczestnika do bazy");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Nie udało się dodać uczestnika do bazy");
                }
                mysqlCon.Close();




            }
        }
    }
}

