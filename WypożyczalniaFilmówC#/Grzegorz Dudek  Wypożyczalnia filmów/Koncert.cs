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
    class Koncert : Nagranie 
    {

        public string gatunek;
        public string nośnik;
        public string lokalizacja;                                  //lokalizajc półki np A4,C2
        public string główny_instrument;
        public string[] ilość_instrumentów = new string[4];
        public string ścieżka;

        public Koncert() : base()
        {
            gatunek = "komedia";
            nośnik = "blu-ray";
            lokalizacja = "3k";
            główny_instrument = "pianino";
        }
        public Koncert(string tytul, string rezyser, string wytwornia, string kraj_prodokcji, int rok_wydania, int ilosc_sztuk, int dlugosc_nagrania, int kategoria_wiekowa, int cena, int max_czas_wypozyczenia,DateTime data_dodania, Bitmap picture, string gatunek, string nośnik, string lokalizacja, string główny_instrument) : base(tytul, rezyser, wytwornia, kraj_prodokcji, rok_wydania, ilosc_sztuk, dlugosc_nagrania, kategoria_wiekowa, cena, max_czas_wypozyczenia,data_dodania,picture)
        {
            this.gatunek = gatunek;
            this.nośnik = nośnik;
            this.lokalizacja = lokalizacja;
            this.główny_instrument = główny_instrument;
        }
        public Koncert(Koncert koncert) : base(koncert)
        {
            gatunek = koncert.gatunek;
            nośnik = koncert.nośnik;
            lokalizacja = koncert.lokalizacja;
            główny_instrument = koncert.główny_instrument;

        }
        ~Koncert()
        {

        }
        public override void Zapisz_do_pliku(StreamWriter sw)
        {
            sw.WriteLine(this.ToString());
            sw.WriteLine(gatunek);
            sw.WriteLine(nośnik);
            sw.WriteLine(lokalizacja);
            sw.WriteLine(główny_instrument);
            base.Zapisz_do_pliku(sw);
            Dodaj();
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(ilość_instrumentów[i]);
            }
            sw.WriteLine(ścieżka);


    }
        public override void Odczytaj_z_pliku(StreamReader sr)
        {   try
            {
                gatunek = sr.ReadLine();
                nośnik = sr.ReadLine();
                lokalizacja = sr.ReadLine();
                główny_instrument = sr.ReadLine();
                base.Odczytaj_z_pliku(sr);
                for (int i = 0; i < 4; i++)
                {
                    ilość_instrumentów[i] = sr.ReadLine();
                }
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
        public void Dodaj()
        {
            ilość_instrumentów[0] = "Skrzypce 20szt";
            ilość_instrumentów[1] = "Wiolonczela 10szt";
            ilość_instrumentów[2] = "Fortepian 1szt";
            ilość_instrumentów[3] = "Flet 5szt";
        }

         public override void Write(ListBox z)
        {
            z.Items.Add("Gatunek: " + gatunek);
            z.Items.Add("Nośnik: " + nośnik);
            z.Items.Add("Lokalizacja: " + lokalizacja);
            z.Items.Add("Główny instrument: " + główny_instrument);
            base.Write(z);
            Dodaj();
            for(int i=0;i<4;i++)
            {
                z.Items.Add(ilość_instrumentów[i]);
            }

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
