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
            //ulubioneList = OdczytajUlubioneZPliku();
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
                //for
                //while (warunek)
                //{
                //ciało pętli
                //}
                //do while
                //foreach
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
