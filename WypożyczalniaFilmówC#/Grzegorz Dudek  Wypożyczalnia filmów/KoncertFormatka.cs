using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grzegorz_Dudek__Wypożyczalnia_filmów
{
    
    public partial class KoncertFormatka : Form
    {
        int i = 0;
        Koncert koncert = new Koncert();
        
        public KoncertFormatka()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = false;
            label1.Text = "Podaj gatunek";
            label1.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                
                koncert.gatunek = textBox1.Text;
                if (koncert.gatunek == "")
                {
                    label1.Text = "Nie podałeś gatunku ";
                    i--;
                    
                }
                else
                {
                    label1.Text = "Podaj rodzaj nośnika: ";
                }
                textBox1.Text = "";
            }
            if (i == 2)
            {

                koncert.nośnik = textBox1.Text;
                if (koncert.nośnik == "")
                {
                    label1.Text = "Nie podałeś rodzaju nośnika ";
                    i--;
                   
                }
                else
                {
                    label1.Text = "Podaj lokalizacje na półce: ";
                }
                textBox1.Text = "";
            }
            if (i == 3)
            {

                koncert.lokalizacja = textBox1.Text;
                if (koncert.lokalizacja == "")
                {
                    label1.Text = "Nie podałeś lokalizacji na półce ";
                    i--;

                }
                else
                {
                    label1.Text = "Podaj główny instrument: ";
                }
                textBox1.Text = "";
            }
            if (i == 4)
            {

                koncert.główny_instrument = textBox1.Text;
                if (koncert.główny_instrument == "")
                {
                    label1.Text = "Nie podełeś głównego instrumentu ";
                    i--;
                    textBox1.Text = "";
                }
                else
                {
                    label1.Text = "Podaj tytuł: ";
                }
                textBox1.Text = "";
            }
            if (i == 5)
            {

                koncert.tytul = textBox1.Text;
                if (koncert.tytul == "")
                {
                    label1.Text = "Nie podałeś tytułu ";
                    i--;

                }
                else
                {
                    label1.Text = "Podaj reżysera: ";
                }
                textBox1.Text = "";
            }
            if (i == 6)
            {

                koncert.rezyser = textBox1.Text;
                if (koncert.rezyser == "")
                {
                    label1.Text = "Nie podałeś reżysera ";
                    i--;

                }
                else
                {
                    label1.Text = "Podaj wytwórnie: ";
                }
                textBox1.Text = "";
            }
            if (i == 7)
            {

                koncert.wytwornia = textBox1.Text;
                if (koncert.wytwornia == "")
                {
                    label1.Text = "Nie podałeś wytwórni ";
                    i--;

                }
                else
                {
                    label1.Text = "Podaj kraj produkcji: ";
                }
                textBox1.Text = "";
            }
            if (i == 8)
            {

                koncert.kraj_prodokcji = textBox1.Text;
                if (koncert.kraj_prodokcji == "")
                {
                    label1.Text = "Nie podałeś kraju produkcji ";
                    i--;
                    textBox1.Text = "";
                }
                else
                {
                    label1.Text = "Podaj rok wydania min: 1961, max 2020: ";
                    textBox1.Text = "";
                    textBox1.Visible = false;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Maximum = 2021;
                    numericUpDown1.Minimum = 1960;
                    numericUpDown1.ResetText();
                }

            }
            if (i == 9)
            {

                koncert.rok_wydania = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.rok_wydania <= 1960) || (koncert.rok_wydania >= 2021))
                {
                    label1.Text = "Podałeś zły rok wydania; min: 1961, max 2020: ";
                    i--;
                }
                else
                {
                    label1.Text = "Podaj ilosc_sztuk min: 1, max 100: ";
                    textBox1.Text = "";
                    numericUpDown1.Maximum = 101;
                    numericUpDown1.Minimum = 0;
                }
                numericUpDown1.ResetText();
            }
            if (i == 10)
            {


                koncert.ilosc_sztuk = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.ilosc_sztuk <= 0) || (koncert.ilosc_sztuk >= 101))
                {
                    label1.Text = "Podałeś złą ilość sztuk; min: 1, max 100: ";
                    i--;
                }
                else
                {

                    label1.Text = "Podaj dlugość nagrania min: 5, max 300: ";
                    numericUpDown1.Maximum = 301;
                    numericUpDown1.Minimum = 4;
                }
                textBox1.Text = "";
                numericUpDown1.ResetText();
            }
            if (i == 11)
            {

                koncert.dlugosc_nagrania = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.dlugosc_nagrania <= 4) || (koncert.dlugosc_nagrania >= 301))
                {
                    label1.Text = "Podałeś złą długość nagrania; min: 5, max 300: ";
                    i--;
                }
                else
                {

                    label1.Text = "Podaj kategoria wiekową max min: 0, max 18: ";
                    numericUpDown1.Maximum = 19;
                    numericUpDown1.Minimum = -1;
                }
                textBox1.Text = "";
                numericUpDown1.ResetText();
            }
            if (i == 12)
            {

                koncert.kategoria_wiekowa = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.kategoria_wiekowa <= -1) || (koncert.kategoria_wiekowa >= 19))
                {
                    label1.Text = "Podałeś złą kategorie wiekową; min: 0, max 18: ";
                    i--;
                }
                else
                {
                    label1.Text = "Podaj cene wypożyczenia min: 0, max 100: ";
                    numericUpDown1.Maximum = 101;
                    numericUpDown1.Minimum = -1;
                }
                textBox1.Text = "";
                numericUpDown1.ResetText();
            }
            if (i == 13)
            {

                koncert.cena = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.cena <= -1) || (koncert.cena >= 101))
                {
                    label1.Text = "Podałeś złą cene wypożyczenia; min: 0, max 100: ";
                    i--;
                }
                else
                {

                    label1.Text = "Podaj maksymalny czas wypożyczenia min:2, max 7: ";
                    numericUpDown1.Maximum = 8;
                    numericUpDown1.Minimum = 1;
                }
                numericUpDown1.ResetText();
                textBox1.Text = "";
            }
            if (i == 14)
            {

                koncert.max_czas_wypozyczenia = Convert.ToInt32(numericUpDown1.Value);
                if ((koncert.max_czas_wypozyczenia <= 1) || (koncert.max_czas_wypozyczenia >= 8))
                {
                    label1.Text = "Podałeś zły max czas wypożyczenia; min: 2, max 7: ";
                    i--;
                }
                else
                {
                    label1.Text = "Ukończyłeś dodawanie";
                    button4.Enabled = false;
                    button2.Enabled = true;
                    koncert.data_dodania = dateTimePicker1.Value.Date;
                    Form1.listaObiektów.listaNagrań.Add(koncert);
                }
                numericUpDown1.ResetText();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            koncert.Write(Koncert);
            button6.Enabled = false;
            button1.Enabled = false;
            pictureBox1.Visible = true;
            button2.Enabled = false;
            Nastepny.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files | *.bmp; *.jpg;  *.png; ";
            openFileDialog1.FilterIndex = 2;

            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                koncert.ścieżka = openFileDialog1.FileName;
                koncert.picture = new Bitmap(koncert.ścieżka);
                pictureBox1.Image = koncert.picture;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                button5.Enabled = false;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            pictureBox1.Visible = true;
            koncert.tytul = "Artur Rubinstein w Filharmonii Narodowej";
            koncert.rezyser = "Muzeum Sztuki Nowoczesnej";
            koncert.wytwornia = " WM Poland";
            koncert.kraj_prodokcji = "Polska";
            koncert.rok_wydania = 2019;
            koncert.ilosc_sztuk = 10;
            koncert.dlugosc_nagrania = 200;
            koncert.kategoria_wiekowa = 3;
            koncert.cena = 20;
            koncert.max_czas_wypozyczenia = 4;
            koncert.data_dodania = dateTimePicker1.Value.Date;
            Form1.listaObiektów.listaNagrań.Add(koncert);
            koncert.Write(Koncert);
            Nastepny.Enabled = true;
        }

        private void Nastepny_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button6.Enabled = true;
            pictureBox1.Image = null;
            Koncert.Items.Clear();
            this.Visible = false;
            KoncertFormatka form1 = new KoncertFormatka();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }
    }
}
