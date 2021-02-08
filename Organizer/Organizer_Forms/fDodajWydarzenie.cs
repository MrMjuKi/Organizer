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
    public partial class fDodajWydarzenie : Form
    {
        string connectionString = @"server=localhost;user id=root;database=Organizer"; 
        int ID = 0;
       
        
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=Organizer");
        
        public fDodajWydarzenie()
        {
            InitializeComponent();
            fill_comboBox1();
            fill_comboBox2();
            fill_comboBox3();
          
            fill_listbox();
        }
        void fill_comboBox1()
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * from organizer.kategoria  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sCategory = myReader.GetString("nazwa_kategorii");
                    cKategoria.Items.Add(sCategory);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fill_comboBox2()
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

                while (myReader.Read())
                {
                    string sPlace = myReader.GetString("nazwa_miejsca");
                    cMiejsce.Items.Add(sPlace);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fill_comboBox3()
        {
            string constring = "server=localhost;user id=root;database=Organizer";
            string Query = "SELECT * from organizer.powtarzalnosc  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sWhen = myReader.GetString("nazwa_powtarzalnosci");
                    cPowtarzalnosc.Items.Add(sWhen);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    string sFriend = myReader.GetString("nazwa");
                    checkedListBox1.Items.Add(sFriend);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void fDodajWydarzenie_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(20, 0, 0, 10);
        }

        private void button3_Click(object sender, EventArgs e)
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
            
            
            odczytaj_dane();
            
        }
        public void stworz_zwykle()
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
            odczytaj_dane();
        }
/*
        public void stworz_standardowe(int ilosc)
        {
            int[] ID_uczestnika = new int[checkedListBox1.CheckedItems.Count];
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                int ile = checkedListBox1.CheckedItems.Count;

                string constring = "server=localhost;user id=root;database=Organizer";
                for (int i = 0; i < ile; i++)
                {
                    string Query = "SELECT * FROM organizer.wspoluczestnik WHERE nazwa='" + checkedListBox1.CheckedItems[i].ToString() + "'  ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();

                        while (myReader.Read())
                        {
                            ID_uczestnika[i] = int.Parse(myReader.GetString("ID_wspoluczestnika"));
                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand wykonaj = new MySqlCommand("DodajWydarzenie", mysqlCon);
                wykonaj.CommandType = CommandType.StoredProcedure;
                wykonaj.Parameters.AddWithValue("_ID_wydarzenia", ID);
                wykonaj.Parameters.AddWithValue("_godzina_rozpoczecia_planowana", start_dtp.Value.AddDays(ilosc));
                wykonaj.Parameters.AddWithValue("_godzina_zakonczenia_planowana", stop_dtp.Value.AddDays(ilosc));
                wykonaj.Parameters.AddWithValue("_opis", opis_txt.Text);
                wykonaj.Parameters.AddWithValue("_ID_miejsca", ID_miejsca);
                wykonaj.Parameters.AddWithValue("_ID_kategorii", ID_kategorii);
                try
                {
                    if (wykonaj.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Dodałeś nowe zadanie");

                    }
                    else
                    {
                        //MessageBox.Show("Nie udało się dodać nowego zadania");
                    }
                    mysqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string insertQuery4 = "INSERT INTO organizer.zdarzenie_standardowe_has_wspoluczestnik(ID_wspoluczestnika,ID_wydarzenia) VALUES ('" + ID_uczestnika[i] + "','" + ID + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery4, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Dodałeś nowe miejsce");
                    }
                    else
                    {
                        //MessageBox.Show("Nie udało się dodać nowego miejsca");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }
     */  
        public void odczytaj_dane()
        {
            int ID_kategorii = 0;
            int ID_miejsca = 0;

            int[] ID_uczestnika = new int[checkedListBox1.CheckedItems.Count];

            if (cKategoria.SelectedItem != null)
            {
                string constring = "server=localhost;user id=root;database=Organizer";
                string Query = "SELECT * FROM organizer.kategoria WHERE nazwa_kategorii='" + cKategoria.SelectedItem.ToString() + "'  ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {
                        ID_kategorii = int.Parse(myReader.GetString("ID_kategorii"));
                    }
                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            if (cMiejsce.SelectedItem != null)
            {
                string constring = "server=localhost;user id=root;database=Organizer";
                string Query = "SELECT * FROM organizer.miejsce WHERE nazwa_miejsca='" + cMiejsce.SelectedItem.ToString() + "'  ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();

                    while (myReader.Read())
                    {
                        ID_miejsca = int.Parse(myReader.GetString("ID_miejsca"));
                    }
                    conDataBase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (checkedListBox1.CheckedItems.Count !=0)
            {
                int ile = checkedListBox1.CheckedItems.Count;
                
                string constring = "server=localhost;user id=root;database=Organizer";
                for (int i = 0; i < ile; i++)
                {
                    string Query = "SELECT * FROM organizer.wspoluczestnik WHERE nazwa='" + checkedListBox1.CheckedItems[i].ToString() + "'  ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();

                        while (myReader.Read())
                        {
                            ID_uczestnika[i] = int.Parse(myReader.GetString("ID_wspoluczestnika"));
                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand wykonaj = new MySqlCommand("DodajWydarzenie", mysqlCon);
                wykonaj.CommandType = CommandType.StoredProcedure;
                wykonaj.Parameters.AddWithValue("_ID_wydarzenia", ID);
                wykonaj.Parameters.AddWithValue("_godzina_rozpoczecia_planowana", start_dtp.Value);
                wykonaj.Parameters.AddWithValue("_godzina_zakonczenia_planowana", stop_dtp.Value);
                wykonaj.Parameters.AddWithValue("_opis", opis_txt.Text);
                wykonaj.Parameters.AddWithValue("_ID_miejsca", ID_miejsca);
                wykonaj.Parameters.AddWithValue("_ID_kategorii", ID_kategorii);
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
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string insertQuery4 = "INSERT INTO organizer.zdarzenie_standardowe_has_wspoluczestnik(ID_wspoluczestnika,ID_wydarzenia) VALUES ('" + ID_uczestnika[i] + "','" + ID + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery4, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        //MessageBox.Show("Dodałeś nowe miejsce");
                    }
                    else
                    {
                        //MessageBox.Show("Nie udało się dodać nowego miejsca");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
            
     /*       
            if (numericUpDown1.Value<0)
            {
                MessageBox.Show("Liczba powtarzanych zdarzeń musi być większa od zera"); 

            }
            else if(numericUpDown1.Value>0)
            {   if(cPowtarzalnosc.SelectedItem.ToString()=="Co tydzień")
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        stworz_zwykle();
                        stworz_standardowe(7);

                    }
                }
                if (cPowtarzalnosc.SelectedItem.ToString() == "Co dwa tygodnie")
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        stworz_zwykle();
                        stworz_standardowe(14);

                    }
                }
            }
     */
           

           

        }
    }
}
