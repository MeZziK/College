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
    abstract public class Nagranie : IComparable<Nagranie>
    {

        
        public string tytul;
        public string rezyser;
        public string wytwornia;
        public string kraj_prodokcji;
        public int rok_wydania;
        public int ilosc_sztuk;
        public int dlugosc_nagrania;
        public int kategoria_wiekowa;
        public int cena;
        public int max_czas_wypozyczenia;
        public DateTime data_dodania;
        public Bitmap picture;

       

        public Nagranie() //konstruktor bezargumentowy
        {
            tytul = "";
            rezyser = "";
            wytwornia = "";
            kraj_prodokcji = "";
            rok_wydania = 0;
            ilosc_sztuk = 0;
            dlugosc_nagrania = 0;
            kategoria_wiekowa = 0;
            cena = 0;
            max_czas_wypozyczenia = 0;
            data_dodania = new DateTime(2020, 1, 1);
        }
       public Nagranie(string tytul,string rezyser,string wytwornia,string kraj_prodokcji,int rok_wydania,int ilosc_sztuk,int dlugosc_nagrania,int kategoria_wiekowa,int cena,int max_czas_wypozyczenia,DateTime data,Bitmap p) //konstruktor wieloargumentowy
        {
            this.tytul = tytul;
            this.rezyser = rezyser;
            this.wytwornia = wytwornia;
            this.kraj_prodokcji = kraj_prodokcji;
            this.rok_wydania = rok_wydania;
            this.ilosc_sztuk = ilosc_sztuk;
            this.dlugosc_nagrania = dlugosc_nagrania;
            this.kategoria_wiekowa = kategoria_wiekowa;
            this.cena = cena;
            this.max_czas_wypozyczenia = max_czas_wypozyczenia;
            this.data_dodania = data;
            this.picture = p;
        }
        public Nagranie(Nagranie nagranie) //konstruktor kopiujący
            {
            tytul = nagranie.tytul;
            rezyser = nagranie.rezyser;
            wytwornia = nagranie.wytwornia;
            kraj_prodokcji = nagranie.kraj_prodokcji;
            rok_wydania = nagranie.rok_wydania;
            ilosc_sztuk = nagranie.ilosc_sztuk;
            dlugosc_nagrania = nagranie.dlugosc_nagrania;
            kategoria_wiekowa = nagranie.kategoria_wiekowa;
            cena = nagranie.cena;
            max_czas_wypozyczenia = nagranie.max_czas_wypozyczenia;
            data_dodania = nagranie.data_dodania;
            picture = nagranie.picture;
        }
        ~Nagranie()
        { }
       virtual public void Write(ListBox k)
        {
            
            k.Items.Add("Tytuł: " + tytul);
            k.Items.Add("Reżyser: "+ rezyser);
            k.Items.Add("Wytwórnia: "+wytwornia);
            k.Items.Add("Kraj produkcji: "+kraj_prodokcji);
            k.Items.Add("Rok wydania: "+rok_wydania);
            k.Items.Add("Ilość sztuk do wypożyczenia: " + ilosc_sztuk);
            k.Items.Add("Czas trwania: "+dlugosc_nagrania);
            k.Items.Add("Kategoria wiekowa: "+kategoria_wiekowa);
            k.Items.Add("Cena wypożyczenia: "+cena);
            k.Items.Add("Czas na oddanie: "+max_czas_wypozyczenia + " dni");
            k.Items.Add("Data dodania: " + data_dodania.ToString("dd.MM.yyyy")); 

        }
        public void Write_kluczowe(ListBox k)
        {
            k.Items.Add(tytul+ " " + rok_wydania + " " + rezyser + " " + wytwornia);
        }
        virtual public void Zapisz_do_pliku(StreamWriter sw)
        {
            sw.WriteLine(tytul);
            sw.WriteLine(rezyser);
            sw.WriteLine(wytwornia);
            sw.WriteLine(kraj_prodokcji);
            sw.WriteLine(rok_wydania);
            sw.WriteLine(ilosc_sztuk);
            sw.WriteLine(dlugosc_nagrania);
            sw.WriteLine(kategoria_wiekowa);
            sw.WriteLine(cena);
            sw.WriteLine(max_czas_wypozyczenia);
            sw.WriteLine(data_dodania);
        }
        virtual public void Odczytaj_z_pliku(StreamReader sr)
        {
            try
            {
                tytul = sr.ReadLine();
                rezyser = sr.ReadLine();
                wytwornia = sr.ReadLine();
                kraj_prodokcji = sr.ReadLine();
                rok_wydania = Convert.ToInt32(sr.ReadLine());
                ilosc_sztuk = Convert.ToInt32(sr.ReadLine());
                dlugosc_nagrania = Convert.ToInt32(sr.ReadLine());
                kategoria_wiekowa = Convert.ToInt32(sr.ReadLine());
                cena = Convert.ToInt32(sr.ReadLine());
                max_czas_wypozyczenia = Convert.ToInt32(sr.ReadLine());
                data_dodania = DateTime.Parse(sr.ReadLine());
            }
            catch(Exception error)
            {
                MessageBox.Show("Przechwycono obiekt wyjątku: " +error.Message);
                MessageBox.Show("Plik jest uszkodzony, brakuje wszystkich potrzebnych danych");
                MessageBox.Show("Nastąpi restart aplikacji");
                Application.Restart();

            }
            finally
            {              
               
            }

        }

           private void Customer()
        {

        }

        public int CompareTo(Nagranie that)
        {   if(this.tytul==that.tytul)
            {
                if(this.rok_wydania==that.rok_wydania)
                {
                    if(this.rezyser==that.rezyser)
                    {
                        return this.wytwornia.CompareTo(that.wytwornia);
                    }
                    else
                    {
                        return this.rezyser.CompareTo(that.rezyser);
                    }
                }
                else
                {
                    return this.rok_wydania.CompareTo(that.rok_wydania);
                }
                    
            }
        else
            {
                return this.tytul.CompareTo(that.tytul);
            }
         
        }

        
    }
    
}
