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
    public partial class Form1 : Form
    {
       // string connectionString = @"server=localhost;user id=root;database=Organizer";
        public Form1()
        {
            InitializeComponent();

            WyswZdarzenOddznaczalnychNaDzis();
            WyswZdarzenOddznaczalnychNaJutro();
            WyswZdarzenOddznaczalnychNaPojutrze();

            WyswZdarzenStandNaDzis();
            WyswZdarzenStandNaJutro();
            WyswZdarzenStandNaPojutrze();

            WyswOpisuDoDzisJutroPojutrze();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDodajWydarzenie f2 = new fDodajWydarzenie();
            f2.ShowDialog();
            listBoxDzis.Items.Clear();
            listBoxJutro.Items.Clear();
            listBoxPojutrze.Items.Clear();
            WyswZdarzenStandNaDzis();
            WyswZdarzenStandNaJutro();
            WyswZdarzenStandNaPojutrze();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fDodajUczestnika f3 = new fDodajUczestnika();
            f3.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fDodajMiejsce f4 = new fDodajMiejsce();
            f4.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fEdytujMiejsce f5 = new fEdytujMiejsce();
            f5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fEdytujZnajomych f6 = new fEdytujZnajomych();
            f6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fDodajZadanie f7 = new fDodajZadanie();
            f7.ShowDialog();
            checkedListBoxDzis.Items.Clear();
            checkedListBoxJutro.Items.Clear();
            checkedListBoxPojutrze.Items.Clear();
            WyswZdarzenOddznaczalnychNaDzis();
            WyswZdarzenOddznaczalnychNaJutro();
            WyswZdarzenOddznaczalnychNaPojutrze();
        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            string str = textBoxWyszukaj.Text; // podstawianie hasła wyszukiwania po zmienną

            szukanieZdarzenPoHasle(str);
        }

        private void szukanieZdarzenPoHasle(string hasloWyszukaj)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_odznaczane.data, zdarzenie_odznaczane.czy_wykonane " +
                " FROM zdarzenie, zdarzenie_odznaczane " +
                " WHERE zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia AND " +
                " zdarzenie.nazwa_zdarzenia LIKE ('%" + hasloWyszukaj.ToString() + "%'); ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            List<string> NazwaZdarzOddzn = new List<string>();
            List<bool> CzyWykonane = new List<bool>();
            List<string> Data = new List<string>();

            while (reader.Read())
            {
                //if (reader.GetString(0) == hasloWyszukaj) //szukanie wydarzen o danej nazwie w bazie
                //{

                //    skladnikiWydarzeniaOdznaczanego.Add(reader.GetString(0));
                //    skladnikiWydarzeniaOdznaczanego.Add(reader.GetString(1));
                //    skladnikiWydarzeniaOdznaczanego.Add(reader.GetString(2));


                //}

                NazwaZdarzOddzn.Add((string)reader["nazwa_zdarzenia"]);
                CzyWykonane.Add((bool)reader["czy_wykonane"]);
                Data.Add(((DateTime)reader["data"]).ToString("dd.MM.yyyy"));

            }

            databaseConnecion.Close();

            //wyswietlanie info o zdarzeniu oddznaczalnym jezeli znalazionow bazie
            if (NazwaZdarzOddzn.Count() != 0)
                for (int i = 0; i < NazwaZdarzOddzn.Count(); i++)
                    _ = new fWyszukajZdarzenieOdzna(NazwaZdarzOddzn[i], CzyWykonane[i], Data[i]);



            // WYSZUKIWANIE ZDARZENA PO PODANEJ NAZWIE ZDARZENIA W ZDARZENIACH STANDARDOWYCH

            string query2 = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_standardowe.godzina_rozpoczecia_planowana " +
                " FROM zdarzenie, zdarzenie_standardowe " +
                " WHERE zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia AND " +
                " zdarzenie.nazwa_zdarzenia LIKE ('%" + hasloWyszukaj.ToString() + "%'); ";

            MySqlConnection databaseConnecion2 = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase2 = new MySqlCommand(query2, databaseConnecion2);
            MySqlDataReader reader2;

            databaseConnecion2.Open();

            reader2 = commandDatabase2.ExecuteReader();


            List<string> NazwaWydStand = new List<string>();
            List<string> GodzRozpocz = new List<string>();

            while (reader2.Read())
            {
                //if (reader2.GetString(0) == hasloWyszukaj) //szukanie wydarzen o danej nazwie w bazie
                //{

                //    skladnikiWydarzeniaStandardowego.Add(reader2.GetString(0));
                //    skladnikiWydarzeniaStandardowego.Add(reader2.GetString(1));
                //    //skladnikiWydarzeniaStandardowego.Add(reader2.GetString(2));


                //}
                NazwaWydStand.Add((string)reader2["nazwa_zdarzenia"]);
                GodzRozpocz.Add(((DateTime)reader2["godzina_rozpoczecia_planowana"]).ToString("yyyy-MM-dd HH:mm"));

            }

            databaseConnecion2.Close();

            //wyswietlanie info o zdarzeniu standardowym jezeli znaleziono w bazie
            if (NazwaWydStand.Count() != 0)
                for (int i = 0; i < NazwaWydStand.Count(); i++)
                    _ = new fWyszukajZdarzenieStand(NazwaWydStand[i], GodzRozpocz[i]);

            //wyswietlanie informacji o nie znalezieniu zdarzenia o podanej nazwie lub nie wpisaniu niczego w pole wyszukiwarki
            if (hasloWyszukaj.Count() == 0 & NazwaZdarzOddzn.Count() == 0 & NazwaWydStand.Count() == 0)
                MessageBox.Show("Nazwa zdarzenia nie została wpisana.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (hasloWyszukaj.Count() != 0 & NazwaZdarzOddzn.Count() == 0 & NazwaWydStand.Count() == 0)
            {
                MessageBox.Show("Brak zdarzenia o podanej nazwie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void WyswZdarzenOddznaczalnychNaDzis()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_odznaczane.czy_wykonane " +
            "FROM zdarzenie, zdarzenie_odznaczane " +
            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia " +
            " AND zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(0).ToString("yyyy-MM-dd") + "'; ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            List<string> nazwaZdarzeOddzna = new List<string>();
            List<bool> czyWykonane = new List<bool>();

            while (reader.Read())
            {
                nazwaZdarzeOddzna.Add((string)reader["nazwa_zdarzenia"]);
                czyWykonane.Add((bool)reader["czy_wykonane"]);
            }

            databaseConnecion.Close();

            for (int i = 0; i < nazwaZdarzeOddzna.Count(); i++)
            {
                checkedListBoxDzis.Items.Add(nazwaZdarzeOddzna[i], fSprawdzajacaCzyZdarzenieWykonaneCzyNie(czyWykonane[i]));
            }


        }

        private CheckState fSprawdzajacaCzyZdarzenieWykonaneCzyNie(bool v) //sprawdza czy zadanie zostało wykonane czy nie
        {
            if (v)
                return CheckState.Checked;
            else
                return CheckState.Unchecked;
        }

        private void WyswZdarzenOddznaczalnychNaJutro()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_odznaczane.czy_wykonane " +
            "FROM zdarzenie, zdarzenie_odznaczane " +
            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia " +
            " AND zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(1).ToString("yyyy-MM-dd") + "'; ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            List<string> nazwaZdarzeOddzna = new List<string>();
            List<bool> czyWykonane = new List<bool>();

            while (reader.Read())
            {
                nazwaZdarzeOddzna.Add((string)reader["nazwa_zdarzenia"]);
                czyWykonane.Add((bool)reader["czy_wykonane"]);
            }

            databaseConnecion.Close();

            for (int i = 0; i < nazwaZdarzeOddzna.Count(); i++)
            {
                checkedListBoxJutro.Items.Add(nazwaZdarzeOddzna[i], fSprawdzajacaCzyZdarzenieWykonaneCzyNie(czyWykonane[i]));
            }



        }

        private void WyswZdarzenOddznaczalnychNaPojutrze()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_odznaczane.czy_wykonane " +
            "FROM zdarzenie, zdarzenie_odznaczane " +
            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia " +
            " AND zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(2).ToString("yyyy-MM-dd") + "'; ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            List<string> nazwaZdarzeOddzna = new List<string>();
            List<bool> czyWykonane = new List<bool>();

            while (reader.Read())
            {
                nazwaZdarzeOddzna.Add((string)reader["nazwa_zdarzenia"]);
                czyWykonane.Add((bool)reader["czy_wykonane"]);
            }

            databaseConnecion.Close();

            for (int i = 0; i < nazwaZdarzeOddzna.Count(); i++)
            {
                checkedListBoxPojutrze.Items.Add(nazwaZdarzeOddzna[i], fSprawdzajacaCzyZdarzenieWykonaneCzyNie(czyWykonane[i]));
            }

        }


        private void WyswZdarzenStandNaDzis()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe.godzina_rozpoczecia_planowana, zdarzenie_standardowe.godzina_zakonczenia_planowana, zdarzenie.nazwa_zdarzenia " +
                " FROM zdarzenie_standardowe, zdarzenie " +
                " WHERE zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia AND " +
                " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKe  ('" + DateTime.Today.AddDays(0).ToString("yyyy-MM-dd") + "%'); "; ;

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            List<string> godzRozpoczecia = new List<string>();
            List<string> godzZakonczenia = new List<string>();
            List<string> nazwaZdarzenia = new List<string>();

            while (reader.Read())
            {



                godzRozpoczecia.Add(((DateTime)reader["godzina_rozpoczecia_planowana"]).ToString("HH:mm"));
                godzZakonczenia.Add(((DateTime)reader["godzina_zakonczenia_planowana"]).ToString("HH:mm"));
                nazwaZdarzenia.Add((string)reader["nazwa_zdarzenia"]);
            }

            for (int i = 0; i < godzRozpoczecia.Count(); i++)
            {
                listBoxDzis.Items.Add(godzRozpoczecia[i] + "  -  " + godzZakonczenia[i] + "    " + nazwaZdarzenia[i]);


                //listViewDzis.Items.Add(godzRozpoczecia[i]);
                //listViewDzis.Items.Add(godzZakonczenia[i]);
                //listViewDzis.Items.Add(nazwaZdarzenia[i]);
            }


        }

        private void WyswZdarzenStandNaJutro()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe.godzina_rozpoczecia_planowana, zdarzenie_standardowe.godzina_zakonczenia_planowana, zdarzenie.nazwa_zdarzenia " +
                " FROM zdarzenie_standardowe, zdarzenie " +
                " WHERE zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia AND " +
                " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKe  ('" + DateTime.Today.AddDays(1).ToString("yyyy-MM-dd") + "%'); "; ;

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            List<string> godzRozpoczecia = new List<string>();
            List<string> godzZakonczenia = new List<string>();
            List<string> nazwaZdarzenia = new List<string>();

            while (reader.Read())
            {



                godzRozpoczecia.Add(((DateTime)reader["godzina_rozpoczecia_planowana"]).ToString("HH:mm"));
                godzZakonczenia.Add(((DateTime)reader["godzina_zakonczenia_planowana"]).ToString("HH:mm"));
                nazwaZdarzenia.Add((string)reader["nazwa_zdarzenia"]);
            }

            for (int i = 0; i < godzRozpoczecia.Count(); i++)
            {
                listBoxJutro.Items.Add(godzRozpoczecia[i] + "  -  " + godzZakonczenia[i] + "    " + nazwaZdarzenia[i]);


                //listViewDzis.Items.Add(godzRozpoczecia[i]);
                //listViewDzis.Items.Add(godzZakonczenia[i]);
                //listViewDzis.Items.Add(nazwaZdarzenia[i]);
            }
        }

        private void WyswZdarzenStandNaPojutrze()
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe.godzina_rozpoczecia_planowana, zdarzenie_standardowe.godzina_zakonczenia_planowana, zdarzenie.nazwa_zdarzenia " +
                " FROM zdarzenie_standardowe, zdarzenie " +
                " WHERE zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia AND " +
                " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKe  ('" + DateTime.Today.AddDays(2).ToString("yyyy-MM-dd") + "%'); "; ;

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            List<string> godzRozpoczecia = new List<string>();
            List<string> godzZakonczenia = new List<string>();
            List<string> nazwaZdarzenia = new List<string>();

            while (reader.Read())
            {



                godzRozpoczecia.Add(((DateTime)reader["godzina_rozpoczecia_planowana"]).ToString("HH:mm"));
                godzZakonczenia.Add(((DateTime)reader["godzina_zakonczenia_planowana"]).ToString("HH:mm"));
                nazwaZdarzenia.Add((string)reader["nazwa_zdarzenia"]);
            }

            for (int i = 0; i < godzRozpoczecia.Count(); i++)
            {
                listBoxPojutrze.Items.Add(godzRozpoczecia[i] + "  -  " + godzZakonczenia[i] + "    " + nazwaZdarzenia[i]);


                //listViewDzis.Items.Add(godzRozpoczecia[i]);
                //listViewDzis.Items.Add(godzZakonczenia[i]);
                //listViewDzis.Items.Add(nazwaZdarzenia[i]);
            }


        }

        private void checkedListBoxDzis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "UPDATE zdarzenie_odznaczane, zdarzenie " +
                " SET zdarzenie_odznaczane.czy_wykonane = IF(zdarzenie_odznaczane.czy_wykonane = 1, 0, 1) " +
                " WHERE zdarzenie.nazwa_zdarzenia LIKE('" + checkedListBoxDzis.SelectedItem.ToString() + "') AND " +
                " zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(0).ToString("yyyy-MM-dd") + "' AND zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia; ";

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            while (reader.Read())
            {

            }

            databaseConnection.Close();
        }

        private void checkedListBoxJutro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nazwaZdarz = checkedListBoxJutro.SelectedItem.ToString();

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "UPDATE zdarzenie_odznaczane, zdarzenie " +
                " SET zdarzenie_odznaczane.czy_wykonane = IF(zdarzenie_odznaczane.czy_wykonane = 1, 0, 1) " +
                " WHERE zdarzenie.nazwa_zdarzenia LIKE('" + checkedListBoxJutro.SelectedItem.ToString() + "') AND " +
                " zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(1).ToString("yyyy-MM-dd") + "' AND zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia; ";

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            while (reader.Read())
            {

            }

            databaseConnection.Close();
        }

        private void checkedListBoxPojutrze_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "UPDATE zdarzenie_odznaczane, zdarzenie " +
                " SET zdarzenie_odznaczane.czy_wykonane = IF(zdarzenie_odznaczane.czy_wykonane = 1, 0, 1) " +
                " WHERE zdarzenie.nazwa_zdarzenia LIKE('" + checkedListBoxPojutrze.SelectedItem.ToString() + "') AND " +
                " zdarzenie_odznaczane.data = '" + DateTime.Today.AddDays(2).ToString("yyyy-MM-dd") + "' AND zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia; ";

            MySqlConnection databaseConnection = new MySqlConnection(ConnectionString);
            MySqlCommand commandDatabse = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabse.ExecuteReader();

            while (reader.Read())
            {

            }

            databaseConnection.Close();
        }

        private void WyswOpisuDoDzisJutroPojutrze()
        {
            labelOpisDzisiaj.Text = DateTime.Today.AddDays(0).ToString("dddd").Substring(0, 1).ToUpper() + DateTime.Today.AddDays(0).ToString("dddd").Substring(1) + "\n (" + DateTime.Today.AddDays(0).ToString("dd.MM.yyy") + ")";
            labelOpisJutro.Text = DateTime.Today.AddDays(1).ToString("dddd").Substring(0, 1).ToUpper() + DateTime.Today.AddDays(1).ToString("dddd").Substring(1) + "\n (" + DateTime.Today.AddDays(1).ToString("dd.MM.yyy") + ")";
            labelOpisPojutrze.Text = DateTime.Today.AddDays(2).ToString("dddd").Substring(0, 1).ToUpper() + DateTime.Today.AddDays(2).ToString("dddd").Substring(1) + "\n (" + DateTime.Today.AddDays(2).ToString("dd.MM.yyy") + ")";

        }

        private void textBoxWyszukaj_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = buttonWyszukaj;
        }

        private void buttonWyszkPoDacie_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePickerWyszukiwarka.Value.ToString("yyyy-MM-dd"));

            if (DateTime.Today.ToString("yyyy-MM-dd") == dateTimePickerWyszukiwarka.Value.ToString("yyyy-MM-dd") ||
                DateTime.Today.AddDays(1).ToString("yyyy-MM-dd") == dateTimePickerWyszukiwarka.Value.ToString("yyyy-MM-dd") ||
                DateTime.Today.AddDays(2).ToString("yyyy-MM-dd") == dateTimePickerWyszukiwarka.Value.ToString("yyyy-MM-dd"))
            {
                MessageBox.Show("Zdarzenia zzukanej daty znajdują się na głównej stronie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fWyswWynikWyszukZdarzPoDacie f = new fWyswWynikWyszukZdarzPoDacie(dateTimePickerWyszukiwarka.Value.ToString("yyyy-MM-dd"), dateTimePickerWyszukiwarka.Value.ToString("dddd"));
                f.ShowDialog();
            }
        }
    }
}
