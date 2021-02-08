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
    public partial class fWyswWynikWyszukZdarzPoDacie : Form
    {
        public fWyswWynikWyszukZdarzPoDacie(string SzukanaData, string dzienTygodnia)
        {
            InitializeComponent();

            labelData.Text = "Wynik wyszukiwania dla " + SzukanaData + " (" + dzienTygodnia + ")";
            label1.Text = SzukanaData;

            WyswZdarzenStand(SzukanaData);
            WyswZdarzenOddznaczalnych(SzukanaData);
        }

        private void WyswZdarzenStand(string data)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe.godzina_rozpoczecia_planowana, zdarzenie_standardowe.godzina_zakonczenia_planowana, zdarzenie.nazwa_zdarzenia " +
                " FROM zdarzenie_standardowe, zdarzenie " +
                " WHERE zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia AND " +
                " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKe  ('" + data + "%'); "; ;

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
                listBoxZdarzStand.Items.Add(godzRozpoczecia[i] + "  -  " + godzZakonczenia[i] + "    " + nazwaZdarzenia[i]);


                //listViewDzis.Items.Add(godzRozpoczecia[i]);
                //listViewDzis.Items.Add(godzZakonczenia[i]);
                //listViewDzis.Items.Add(nazwaZdarzenia[i]);
            }
        }

        private void WyswZdarzenOddznaczalnych(string data)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_odznaczane.czy_wykonane " +
            "FROM zdarzenie, zdarzenie_odznaczane " +
            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia " +
            " AND zdarzenie_odznaczane.data = '" + data + "'; ";

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
                checkedListBoxZdarzOddzn.Items.Add(nazwaZdarzeOddzna[i], fSprawdzajacaCzyZdarzenieWykonaneCzyNie(czyWykonane[i]));
            }

        }

        private CheckState fSprawdzajacaCzyZdarzenieWykonaneCzyNie(bool v) //sprawdza czy zadanie zostało wykonane czy nie
        {
            if (v)
                return CheckState.Checked;
            else
                return CheckState.Unchecked;
        }

        private void checkedListBoxZdarzOddzn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string ConnectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "UPDATE zdarzenie_odznaczane, zdarzenie " +
                " SET zdarzenie_odznaczane.czy_wykonane = IF(zdarzenie_odznaczane.czy_wykonane = 1, 0, 1) " +
                " WHERE zdarzenie.nazwa_zdarzenia LIKE('" + checkedListBoxZdarzOddzn.SelectedItem.ToString() + "') AND " +
                " zdarzenie_odznaczane.data LIKE ('" + label1.Text + "%') AND zdarzenie.ID_wydarzenia = zdarzenie_odznaczane.ID_wydarzenia; ";

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
    }
}
