using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wygaszacz
{


    public partial class Przegladarka : Form
    {
        List<Ulubione> ulubioneList; // tworzymy liste ulubionych adresow
        public Przegladarka()
        {
            InitializeComponent();
            ulubioneList = new List<Ulubione>(); // inicjalizacja listy
            ulubioneList = OdczytajUlubioneZPliku();
            OdswiezListeUlubionych();
        }

        private void ZapiszDoUlubionych(string url, string tytul)
        {
            Ulubione strona = new Ulubione(url, tytul); // tworzymy nową ulubioną
            ulubioneList.Add(strona);
            ZapiszUlubioneDoPliku(strona);
            OdswiezListeUlubionych();
        }
        
        private void OdswiezListeUlubionych()
        {
            ulubioneCmb.DataSource = null;
            ulubioneCmb.DataSource = ulubioneList;
        }

        private void ZapiszUlubioneDoPliku(Ulubione ulubione) //metoda zapisująca do pliku
        {
            using (StreamWriter sw = new StreamWriter(@"E:\ulubione.txt", true))
                //true powoduje dopisanie a nie nadpisanie
            {
                sw.WriteLine("{0}|{1}", ulubione.Url, ulubione.TytulStrony);
                //wczytujemy adres strony i url do pliku
                //rozdzielamy |
                //by było bardizej przejrzyste

            }
        }

            //metoda odczytujaca z pliku
        private List<Ulubione> OdczytajUlubioneZPliku()
        {
            List<Ulubione> lista = new List<Ulubione>();
            using(StreamReader sr = new StreamReader(@"E:\ulubione.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] elementy = line.Split('|');
                    Ulubione ulubione = new Ulubione(elementy[0], elementy[1]);
                    lista.Add(ulubione);
                }
            }
        return lista;
        }

        private void IdzBtn_Click(object sender, EventArgs e)
        {
            if(AdresTxt.Text != null)
            {
                okienkoBrw.Navigate(AdresTxt.Text);
            }
            else
            {
                //jezeli ktos probuje wpisac wpusty
                MessageBox.Show("Nie wpisales adresu strony!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void okienkoBrw_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            AdresTxt.Text = okienkoBrw.Url.ToString();
            //adres w adrestxt zmieniamy na aktualny adres wczytania strony
            if(okienkoBrw.CanGoForward)
            {
                WprzodBtn.Enabled = true;
            }
            else
            {
                WprzodBtn.Enabled = false;
            }

            if(okienkoBrw.CanGoBack)
            {
                WsteczBtn.Enabled = true;
            }
            else
            {
                WsteczBtn.Enabled = false;
            }        
        }

        private void WsteczBtn_Click(object sender, EventArgs e)
        {
            okienkoBrw.GoBack();
        }

        private void WprzodBtn_Click(object sender, EventArgs e)
        {
            okienkoBrw.GoForward();
        }

        private void ZatrzymajBtn_Click(object sender, EventArgs e)
        {
            okienkoBrw.Stop();
        }

        private void OdswiezBtn_Click(object sender, EventArgs e)
        {
            okienkoBrw.Refresh();
        }

        private void ulubioneBtn_Click(object sender, EventArgs e)
        {
            string url = AdresTxt.Text;
            string tytul = okienkoBrw.Document.Title;
            ZapiszDoUlubionych(url, tytul);
        }

        private void ulubioneCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ulubione ulubione = ulubioneCmb.SelectedItem as Ulubione;
            AdresTxt.Text = ulubione.Url;
            okienkoBrw.Navigate(AdresTxt.Text);
           
        }
    }

    public class Ulubione
    {
        public string Url;
        public string TytulStrony;

        public Ulubione(string url, string tytul)
        {
            Url = url;
            TytulStrony = tytul;
        }

        public override string ToString() //nadpisana metoda ToString by moc wyswietlac w comboboxie
        {
            return TytulStrony;
        }
    }


}
