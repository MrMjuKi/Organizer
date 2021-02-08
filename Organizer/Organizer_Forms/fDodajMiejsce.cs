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
    public partial class fDodajMiejsce : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=Organizer");
        public fDodajMiejsce()
        {
            InitializeComponent();
        }
        private void fDodajMiejsce_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO organizer.miejsce(nazwa_miejsca,ulica,numer_domu,numer_mieszkania,kod_pocztowy,miejscowosc) VALUES ('" + nazwa_txt.Text + "','" + ulica_txt.Text + "','" + dom_txt.Text + "','" + mieszkanie_txt.Text + "','" + kod_txt.Text + "','" + miasto_txt.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dodałeś nowe miejsce");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać nowego miejsca");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
