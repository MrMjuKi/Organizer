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
    public partial class fDodajZadanie : Form
    {
        int ID = 0;
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=Organizer");
        string connectionString = @"server=localhost;user id=root;database=Organizer";
        public fDodajZadanie()
        {
            InitializeComponent();
        }
        /*
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
        */
        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO organizer.zdarzenie(nazwa_zdarzenia) VALUES ('" + nazwa_txt.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("Dodałeś nowe zadanie");
                    String Query2 = "SELECT * FROM organizer.zdarzenie WHERE ID_wydarzenia = LAST_INSERT_ID()";
                    MySqlCommand cmd2 = new MySqlCommand(Query2, connection);
                    MySqlDataReader reader;
                    try
                    {
                        reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            ID = int.Parse(reader.GetString("ID_wydarzenia"));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    //MessageBox.Show("Nie udało się dodać nowego zadania");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            dodaj2();
        }

        public void dodaj2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand wykonaj = new MySqlCommand("DodajZadanie", mysqlCon);
                wykonaj.CommandType = CommandType.StoredProcedure;
                wykonaj.Parameters.AddWithValue("_data", dtp.Value.Date);
                wykonaj.Parameters.AddWithValue("_ID_zdarzenia", ID);
                try
                {
                    if (wykonaj.ExecuteNonQuery() == 1)
                    {
                       MessageBox.Show("Dodałeś nowe zadanie");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Nie udało się dodać nowego zadania");
                    }
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 20, 0, 0);
        }
    }

   
}
