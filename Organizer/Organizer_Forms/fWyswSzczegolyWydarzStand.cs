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
    public partial class fWyswSzczegolyWydarzStand : Form
    {
        public string IDzdarzenia = "";

        public fWyswSzczegolyWydarzStand(string nazwaZdarz, string czasPoczatkuZdarz)
        {
            InitializeComponent();
            //MessageBox.Show(nazwaZdarz + czasPoczatkuZdarz);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm";

            jakieIDzdarzenia(nazwaZdarz, czasPoczatkuZdarz);
            //MessageBox.Show(nazwaZdarz + czasPoczatkuZdarz);
            wczytanieDanych(nazwaZdarz, czasPoczatkuZdarz);
        }

        private void jakieIDzdarzenia(string nazwa, string dataPoczatkowa)
        {
            //MessageBox.Show(nazwa + dataPoczatkowa , "jakie id zdarzenia");
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.ID_wydarzenia " +
                            " FROM zdarzenie_standardowe, zdarzenie " +
                            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_standardowe.ID_wydarzenia AND " +
                            " zdarzenie.nazwa_zdarzenia LIKE('" + nazwa + "') AND " +
                            " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKE('" + dataPoczatkowa + "%'); ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();



            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    IDzdarzenia = ((int)reader["ID_wydarzenia"]).ToString();
                }
            }

            databaseConnecion.Close();
        }

        private void wczytanieDanych(string nazwa, string dataPocz)
        {
            //MessageBox.Show(nazwa + "  " + dataPocz, "wszytanie danych");

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie.nazwa_zdarzenia, zdarzenie_standardowe.godzina_rozpoczecia_planowana, zdarzenie_standardowe.godzina_zakonczenia_planowana, " +
                "IFNULL(zdarzenie_standardowe.godzina_rozpoczecia_rzeczywista, NOW()), IFNULL(zdarzenie_standardowe.godzina_zakonczenia_rzeczywista, NOW()), zdarzenie_standardowe.opis, kategoria.nazwa_kategorii, " +
                "miejsce.miejscowosc, miejsce.nazwa_miejsca, miejsce.ulica, miejsce.numer_domu, miejsce.numer_mieszkania, miejsce.kod_pocztowy " +
                " FROM zdarzenie, zdarzenie_standardowe, kategoria, miejsce " +
                " WHERE zdarzenie.ID_wydarzenia = zdarzenie_standardowe.ID_wydarzenia AND " +
                " zdarzenie_standardowe.ID_kategorii = kategoria.ID_kategorii AND " +
                " zdarzenie_standardowe.ID_miejsca = miejsce.ID_miejsca AND " +
                " zdarzenie.nazwa_zdarzenia LIKE('" + nazwa + "') AND zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKE('" + dataPocz + "%')";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            List<string> Informacje = new List<string>();
            string miejsce = "";

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    //MessageBox.Show(((string)reader["nazwa_zdarzenia"]));
                    textBox1.Text = ((string)reader["nazwa_zdarzenia"]);
                    dateTimePicker1.Value = ((DateTime)reader["godzina_rozpoczecia_planowana"]);
                    dateTimePicker2.Value = (DateTime)reader["godzina_zakonczenia_planowana"];
                    dateTimePicker3.Value = (DateTime)reader["IFNULL(zdarzenie_standardowe.godzina_rozpoczecia_rzeczywista, NOW())"];
                    dateTimePicker4.Value = (DateTime)reader["IFNULL(zdarzenie_standardowe.godzina_zakonczenia_rzeczywista, NOW())"];
                    textBox6.Text = ((string)reader["opis"]);
                    textBox7.Text = ((string)reader["miejscowosc"]);
                    miejsce = ((string)reader["nazwa_miejsca"]);
                    textBox9.Text = ((string)reader["ulica"]);
                    textBox10.Text = ((string)reader["numer_domu"]);
                    textBox13.Text = ((string)reader["numer_mieszkania"]);
                    textBox11.Text = ((string)reader["kod_pocztowy"]);


                }
            }

            databaseConnecion.Close();
            WyswListeMiejsc(nazwa, dataPocz, miejsce);
        }

        private void WyswListeMiejsc(string nazwa, string dataPocz, string miejsce)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT miejsce.nazwa_miejsca " +
                            " FROM miejsce " +
                            " ORDER BY miejsce.ID_miejsca ASC";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();



            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (miejsce == (string)reader["nazwa_miejsca"]) checkedListBox3.Items.Add((string)reader["nazwa_miejsca"], CheckState.Checked);
                    else checkedListBox3.Items.Add((string)reader["nazwa_miejsca"], CheckState.Unchecked);
                }
            }

            databaseConnecion.Close();

            ZaznaczanieAktualnejKategorii(nazwa, dataPocz);
        }

        private void ZaznaczanieAktualnejKategorii(string nazwa, string dataPocz)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe.ID_kategorii " +
                            " FROM zdarzenie_standardowe, zdarzenie " +
                            " WHERE zdarzenie.ID_wydarzenia = zdarzenie_standardowe.ID_wydarzenia AND " +
                             " zdarzenie.nazwa_zdarzenia LIKE('" + nazwa + "') AND " +
                            " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKE ('" + dataPocz + "%'); ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();

            int idKategorii = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idKategorii = (int)reader["ID_kategorii"];
                }
            }

            databaseConnecion.Close();

            WyswKategorii(nazwa, dataPocz, idKategorii);
        }

        private void WyswKategorii(string nazwa, string dataPocz, int idKategorii)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT kategoria.nazwa_kategorii " +
                            " FROM kategoria " +
                            " ORDER BY kategoria.ID_kategorii ASC";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            int i = 1;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (i == idKategorii) checkedListBox1.Items.Add((string)reader["nazwa_kategorii"], CheckState.Checked);
                    else checkedListBox1.Items.Add((string)reader["nazwa_kategorii"], CheckState.Unchecked);

                    i++;
                }
            }



            databaseConnecion.Close();
            ZnalezienieIdWspoluczestnikow(nazwa, dataPocz);
        }

        private void ZnalezienieIdWspoluczestnikow(string nazwa, string dataPocz)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT zdarzenie_standardowe_has_wspoluczestnik.ID_wspoluczestnika " +
                           " FROM zdarzenie_standardowe_has_wspoluczestnik " +
                                " WHERE zdarzenie_standardowe_has_wspoluczestnik.ID_wydarzenia = (SELECT zdarzenie.ID_wydarzenia " +
                                " FROM zdarzenie_standardowe, zdarzenie " +
                                " WHERE zdarzenie.nazwa_zdarzenia LIKE('" + nazwa + "') AND " +
                                " zdarzenie_standardowe.godzina_rozpoczecia_planowana LIKE('" + dataPocz + "%') AND " +
                                " zdarzenie.ID_wydarzenia = zdarzenie_standardowe.ID_wydarzenia ) " +
                           " ORDER BY zdarzenie_standardowe_has_wspoluczestnik.ID_wspoluczestnika ASC";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();

            List<int> listaWspoluczZdarz = new List<int>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaWspoluczZdarz.Add((int)reader["ID_wspoluczestnika"]);
                }
            }



            databaseConnecion.Close();
            WyswListyWspoluczestnikow(listaWspoluczZdarz);
        }

        private void WyswListyWspoluczestnikow(List<int> listaWspoluczZdarz)
        {
            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT wspoluczestnik.nazwa " +
                            " FROM wspoluczestnik " +
                            " ORDER BY wspoluczestnik.ID_wspoluczestnika ASC";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();

            int i = 1;
            int j = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (listaWspoluczZdarz.Count() != 0)
                    {
                        if (listaWspoluczZdarz[listaWspoluczZdarz.Count() - 1] >= i & i == listaWspoluczZdarz[j % listaWspoluczZdarz.Count()])
                        {
                            checkedListBox2.Items.Add((string)reader["nazwa"], CheckState.Checked);
                            i++;
                            j++;
                            //listaWspoluczZdarz.RemoveAt(0);
                        }
                        else
                        {
                            checkedListBox2.Items.Add((string)reader["nazwa"], CheckState.Unchecked);
                            i++;
                        }
                    }
                    else
                    {
                        checkedListBox2.Items.Add((string)reader["nazwa"], CheckState.Unchecked);

                    }

                }
            }

            databaseConnecion.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                Int32 checkedItemIndex = checkedListBox1.CheckedIndices[0];
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedItemIndex, false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedListBox1.CheckedIndices[0];
                    checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                    checkedListBox1.SetItemChecked(checkedItemIndex, false);
                    checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
                }

                return;
            }

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox3.CheckedItems.Count > 1)
            {
                Int32 checkedItemIndex = checkedListBox3.CheckedIndices[0];
                checkedListBox3.ItemCheck -= checkedListBox3_ItemCheck;
                checkedListBox3.SetItemChecked(checkedItemIndex, false);
                checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox3.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = checkedListBox3.CheckedIndices[0];
                    checkedListBox3.ItemCheck -= checkedListBox3_ItemCheck;
                    checkedListBox3.SetItemChecked(checkedItemIndex, false);
                    checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;

                    zmianaInfoMiejsca();
                    return;
                }

            }


        }

        private void zmianaInfoMiejsca()
        {
            //MessageBox.Show(checkedListBox3.SelectedItem.ToString());

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            string query = "SELECT miejsce.miejscowosc, miejsce.ulica, miejsce.numer_domu, miejsce.numer_mieszkania, miejsce.kod_pocztowy " +
                            " FROM miejsce " +
                            " WHERE miejsce.nazwa_miejsca LIKE('" + checkedListBox3.SelectedItem.ToString() + "'); ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox7.Text = ((string)reader["miejscowosc"]);
                    textBox9.Text = ((string)reader["ulica"]);
                    textBox10.Text = ((string)reader["numer_domu"]);
                    textBox13.Text = ((string)reader["numer_mieszkania"]);
                    textBox11.Text = ((string)reader["kod_pocztowy"]);
                }
            }

            databaseConnecion.Close();

            return;

        }

        private void buttonWprowadzZmiany_Click(object sender, EventArgs e)
        {
            string IDmiejsca = "";
            for (int i = 0; i <= checkedListBox3.CheckedIndices.Count - 1; i++)
                IDmiejsca = (1 + checkedListBox3.CheckedIndices[i]).ToString();

            string IDkategori = "";
            for (int i = 0; i <= checkedListBox1.CheckedIndices.Count - 1; i++)
                IDkategori = (1 + checkedListBox1.CheckedIndices[i]).ToString();
            funkcja(IDmiejsca, IDkategori);
        }

        private void funkcja(string IDmiejsca, string IDkategori)
        {
            //MessageBox.Show(checkedListBox3.SelectedItem.ToString());

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            //WYSZUKIWANIE ZDARZENIA PO NAZWIE ZDARZENIA W ZDARZENIACH ODZNACZALNYCH
            //string query = "UPDATE zdarzenie, zdarzenie_standardowe " +
            //                " SET zdarzenie.nazwa_zdarzenia = '" + textBox1.ToString() + "' ," +
            //                " zdarzenie_standardowe.godzina_rozpoczecia_planowana = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
            //                " zdarzenie_standardowe.godzina_zakonczenia_planowana = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
            //                " zdarzenie_standardowe.godzina_rozpoczecia_rzeczywista = '" + dateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
            //                " zdarzenie_standardowe.godzina_zakonczenia_rzeczywista = '"  + dateTimePicker4.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
            //                " zdarzenie_standardowe.opis = '" + textBox6.Text.ToString() + "', " +
            //                " zdarzenie_standardowe.ID_miejsca = (SELECT miejsce.ID_miejsca FROM miejsce WHERE miejsce.nazwa_miejsca LIKE ('" + checkedListBox3.SelectedItem.ToString() + "') ), " +
            //                " zdarzenie_standardowe.ID_kategorii = (SELECT kategoria.ID_kategorii FROM kategoria WHERE kategoria.nazwa_kategorii LIKE ('" + checkedListBox1.SelectedItem.ToString() + "') ) " +
            //                " WHERE zdarzenie.ID_wydarzenia LIKE " + IDzdarzenia.ToString() + " AND " +
            //                " zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia; ";

            string query = "UPDATE zdarzenie, zdarzenie_standardowe " +
                            " SET zdarzenie.nazwa_zdarzenia = '" + textBox1.Text.ToString() + "', " +
                            " zdarzenie_standardowe.godzina_rozpoczecia_planowana = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HHH:mm:ss") + "', " +
                            " zdarzenie_standardowe.godzina_zakonczenia_planowana = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            " zdarzenie_standardowe.godzina_rozpoczecia_rzeczywista = '" + dateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            " zdarzenie_standardowe.godzina_zakonczenia_rzeczywista = '" + dateTimePicker4.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            " zdarzenie_standardowe.opis = '" + textBox6.Text.ToString() + "', " +
                            " zdarzenie_standardowe.ID_miejsca = " + IDmiejsca + ", " +
                            " zdarzenie_standardowe.ID_kategorii = " + IDkategori + " " +
                            " WHERE zdarzenie.ID_wydarzenia LIKE " + IDzdarzenia + " AND " +
                            " zdarzenie_standardowe.ID_wydarzenia = zdarzenie.ID_wydarzenia; ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();
            //MessageBox.Show("Udało się wprowadzić zmiany");

            List<int> ListaIDwspoluczestnikow = new List<int>();
            for (int i = 0; i <= checkedListBox2.CheckedIndices.Count - 1; i++)
                ListaIDwspoluczestnikow.Add(1 + checkedListBox2.CheckedIndices[i]);

            query = "DELETE FROM zdarzenie_standardowe_has_wspoluczestnik " +
                    " WHERE zdarzenie_standardowe_has_wspoluczestnik.ID_wydarzenia = " + IDzdarzenia + "";

            commandDatabase = new MySqlCommand(query, databaseConnecion);
            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();

            for (int i = 0; i <= ListaIDwspoluczestnikow.Count() - 1; i++)
                dodawanieWspoluczestnikow(ListaIDwspoluczestnikow[i]);

            MessageBox.Show("Udało się wprowadzić zmiany :D");
            this.Close();
            Application.Restart();
            //Environment.Exit(0);


        }

        private void dodawanieWspoluczestnikow(int IDwspol)
        {
            //MessageBox.Show(checkedListBox3.SelectedItem.ToString());

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            string query = "INSERT INTO `zdarzenie_standardowe_has_wspoluczestnik` (`ID_wydarzenia`, `ID_wspoluczestnika`) VALUES ('" + IDzdarzenia + "', '" + IDwspol.ToString() + "'); ";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(checkedListBox3.SelectedItem.ToString());

            //string potrzebny do ustalenia polaczenia z daza danych w dwoch wyszukiwarkach zdarzen
            string connectionString = "server=localhost;user id=root;database=organizer;allowuservariables=True";

            string query = "DELETE FROM zdarzenie WHERE zdarzenie.ID_wydarzenia = "+IDzdarzenia+" ;";

            MySqlConnection databaseConnecion = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnecion);
            MySqlDataReader reader;

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();

            query = "DELETE FROM zdarzenie_standardowe WHERE zdarzenie_standardowe.ID_wydarzenia = "+IDzdarzenia+";";
            commandDatabase = new MySqlCommand(query, databaseConnecion);
            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();


            query = "DELETE FROM zdarzenie_standardowe_has_wspoluczestnik WHERE zdarzenie_standardowe_has_wspoluczestnik.ID_wydarzenia ="+IDzdarzenia+" ";
            commandDatabase = new MySqlCommand(query, databaseConnecion);

            databaseConnecion.Open();

            reader = commandDatabase.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {

                }
            }

            databaseConnecion.Close();

            MessageBox.Show("Wydarzenie zostało porpawnie usunięte");
            this.Close();
            Application.Restart();
            //Environment.Exit(0);

        }
    }
}
