using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Grzegorz_Dudek__Wypożyczalnia_filmów
{
     class Film : Nagranie
    {


        public string gatunek;
        public string nośnik;
        public string lokalizacja;                                  //lokalizajc półki np A4,C2
        public string wersja_okładki;
        public string ścieżka;

        public Film():base()
        {
            gatunek = "Akcja";
            nośnik = "blu-ray";
            lokalizacja = "3k";
            wersja_okładki = "pierwsza";
        }
        public Film(string tytul, string rezyser, string wytwornia, string kraj_prodokcji, int rok_wydania, int ilosc_sztuk, int dlugosc_nagrania, int kategoria_wiekowa, int cena, int max_czas_wypozyczenia,DateTime data_dodania,Bitmap picture, string gatunek,string nośnik,string lokalizacja,string wersja_okładki):base(tytul, rezyser,  wytwornia,  kraj_prodokcji,  rok_wydania,  ilosc_sztuk,  dlugosc_nagrania,  kategoria_wiekowa,  cena,  max_czas_wypozyczenia,data_dodania,picture)
        {
            this.gatunek = gatunek;
            this.nośnik = nośnik;
            this.lokalizacja = lokalizacja;
            this.wersja_okładki = wersja_okładki;
        }
        public Film(Film film):base(film)
        {
            gatunek = film.gatunek;
            nośnik = film.nośnik;
            lokalizacja = film.lokalizacja;
            wersja_okładki = film.wersja_okładki;
                
        }
        ~Film()
        {
        
        }
        public static bool operator ==(Film film_1,Film film_2)
        {
            if(film_1.tytul==film_2.tytul)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Film film_1,Film film_2)
        {
            if(film_1.tytul!=film_2.tytul)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Film operator+(Film film_1, Film film_2)
        {
            Film film_3 = new Film();
            film_3.tytul = film_1.tytul + film_2.tytul;
            return film_3;
        }
        public override void Zapisz_do_pliku(StreamWriter sw)
        {
            sw.WriteLine(this.ToString());
            sw.WriteLine(gatunek);
            sw.WriteLine(nośnik);
            sw.WriteLine(lokalizacja);
            sw.WriteLine(wersja_okładki);
            base.Zapisz_do_pliku(sw);
            sw.WriteLine(ścieżka);
        }

        public override void Odczytaj_z_pliku(StreamReader sr)
        {
            try
            {
                gatunek = sr.ReadLine();
                nośnik = sr.ReadLine();
                lokalizacja = sr.ReadLine();
                wersja_okładki = sr.ReadLine();
                base.Odczytaj_z_pliku(sr);
                ścieżka = sr.ReadLine();
            }
            catch (Exception error)
            {
                MessageBox.Show("Przechwycono obiekt wyjątku: " + error.Message);
                MessageBox.Show("Plik jest uszkodzony, brakuje wszystkich potrzebnych danych");
                MessageBox.Show("Nastąpi restart aplikacji");
                Application.Restart();
            }
            finally
            {

            }


        }


        override public void Write(ListBox x)
        {
            base.Write(x);
            x.Items.Add("Gatunek: " + gatunek);
            x.Items.Add("Nośnik: " + nośnik);
            x.Items.Add("Lokalizacja: " + lokalizacja);
            x.Items.Add("Wersja okładki: " + wersja_okładki);
            
                 
        }

    }
}
