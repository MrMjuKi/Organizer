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
    public partial class fEdytujMiejsce : Form
    {
        int ID = 0;
        public fEdytujMiejsce()
        {
            InitializeComponent();
            fill_listbox();
        }

        void fill_listbox()
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * from organizer.miejsce  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                while(myReader.Read())
                {
                    string sName = myReader.GetString("nazwa_miejsca");
                    listBox1.Items.Add(sName);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * FROM organizer.miejsce WHERE nazwa_miejsca='" + listBox1.Text + "'  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    ID = int.Parse(myReader.GetString("ID_miejsca"));
                    string sName = myReader.GetString("nazwa_miejsca");
                    string sStreet = myReader.GetString("ulica");
                    string sHome = myReader.GetString("numer_domu");
                    string sFlat = myReader.GetString("numer_mieszkania");
                    string sCode = myReader.GetString("kod_pocztowy");
                    string sCity = myReader.GetString("miejscowosc");

                    nazwa_txt.Text = sName;
                    ulica_txt.Text = sStreet;
                    dom_txt.Text = sHome;
                    mieszkanie_txt.Text = sFlat;
                    kod_txt.Text = sCode;
                    miasto_txt.Text = sCity;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "UPDATE organizer.miejsce SET nazwa_miejsca ='" + this.nazwa_txt.Text + "', ulica='" + this.ulica_txt.Text + "', numer_domu='" + this.dom_txt.Text + "', numer_mieszkania='" + this.mieszkanie_txt.Text + "', kod_pocztowy='" + this.kod_txt.Text + "', miejscowosc='" + this.miasto_txt.Text + "' WHERE ID_miejsca='" + this.ID + "'; ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Dane zostały zmienione");
                while (myReader.Read())
                {

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "DELETE FROM organizer.miejsce WHERE ID_miejsca= '" + this.ID + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Usunięto miejsce");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 20, 0, 0);
        }
    }
}

