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
    public partial class fEdytujZnajomych : Form
    {
        int ID = 0;
        
        public fEdytujZnajomych()
        {
            InitializeComponent();
            fill_listbox();
        }
        
        void fill_listbox()
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * from organizer.wspoluczestnik  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("nazwa");
                    listBox1.Items.Add(sName);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * FROM organizer.wspoluczestnik WHERE nazwa='" + listBox1.Text + "'  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    ID = int.Parse(myReader.GetString("ID_wspoluczestnika"));
                    string sName = myReader.GetString("nazwa");
                   // string sSurname = myReader.GetString("nazwisko");
                    string sNum = myReader.GetString("nr_telefonu");
                   // string dDate = myReader.GetString("data_urodzenia");
                    DateTimePicker1.Value = myReader.GetDateTime("data_urodzenia");
                   
                    string sRelation = myReader.GetString("relacja");

                    imie_txt.Text = sName;
                   // nazwisko_txt.Text = sSurname;
                    tel_txt.Text = sNum;
                   // date_txt.Text = dDate;
                    relacja_txt.Text = sRelation;

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
            string connectionString = @"server=localhost;user id=root;database=Organizer";
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                try
                {
                    
                    mysqlCon.Open();
                    MySqlCommand zmien = new MySqlCommand("DodajUczestnika", mysqlCon);
                    zmien.CommandType = CommandType.StoredProcedure;
                    
                    zmien.Parameters.AddWithValue("_ID_wspoluczestnika", ID);
                    zmien.Parameters.AddWithValue("_imie", imie_txt.Text.Trim());
                   // zmien.Parameters.AddWithValue("_nazwisko", nazwisko_txt.Text.Trim());
                    zmien.Parameters.AddWithValue("_relacja", relacja_txt.Text.Trim());
                    zmien.Parameters.AddWithValue("_data_urodzenia", DateTimePicker1.Value.Date);
                    zmien.Parameters.AddWithValue("_nr_telefonu", tel_txt.Text.Trim());
                    if (zmien.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Dane zmienione");

                    }
                    else
                    {
                        MessageBox.Show("Nie udało się zmienić danych");
                    }
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

            /*
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "UPDATE organizer.wspoluczestnik SET imie ='" + this.imie_txt.Text + "', nazwisko='" + this.nazwisko_txt.Text + "', nr_telefonu='" + this.tel_txt.Text + "', data_urodzenia='" + this.DateTimePicker1.Value + "', relacja='" + this.relacja_txt.Text + "' WHERE ID_wspoluczestnika='" + this.ID + "'; ";
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
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "DELETE FROM organizer.wspoluczestnik WHERE ID_wspoluczestnika= '"+ ID +"';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Usunięto znajomego");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
