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
    public partial class InformacjeObiekty : Form
    {
        public InformacjeObiekty()
        {
            InitializeComponent();
            if (Form1.listaObiektów.listaNagrań.Count == 0)
            {
                label1.Visible = true;
                sortowanie.Enabled = false;
                wyświetlanie.Enabled = false;

                label1.Text = "Brak obiektów na liście";
            }
            else
            {
                sortowanie.Enabled = true;
                wyświetlanie.Enabled = true;
            }
        }

        private void sortowanie_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form1.listaObiektów.listaNagrań.Sort();
            foreach (Nagranie n in Form1.listaObiektów.listaNagrań)
            {
                
                n.Write_kluczowe(listBox1);
                if (Form1.listaObiektów.listaNagrań.Count() > 1)
                {
                    listBox1.Items.Add("");
                }
            }
        }

        private void wyświetlanie_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Nagranie n in Form1.listaObiektów.listaNagrań)
            {

                n.Write_kluczowe(listBox1);
                if (Form1.listaObiektów.listaNagrań.Count() > 1)
                {
                    listBox1.Items.Add("");
                }
            }
        }

        private void powrót_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;
        }

        private void przykładowe_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            przykładowe.Enabled = false;

            Koncert koncert1 = new Koncert();
            Koncert koncert2 = new Koncert();
            Koncert koncert3 = new Koncert();
            koncert1.tytul = "Artur Rubinstein w Filharmonii Narodowej";
            koncert1.rezyser = "Muzeum Sztuki Nowoczesnej";
            koncert1.wytwornia = " WM Poland";
            koncert1.rok_wydania = 2019;       
            Form1.listaObiektów.listaNagrań.Add(koncert1);
            koncert2.tytul = "Aaa";
            koncert2.rezyser = "Muzeum Sztuki Nowoczesnej";
            koncert2.wytwornia = " WM Poland";
            koncert2.rok_wydania = 2019;
            Form1.listaObiektów.listaNagrań.Add(koncert2);
            koncert3.tytul = "Aaa";
            koncert3.rezyser = "Mazeum ";
            koncert3.wytwornia = " WM Poland";
            koncert3.rok_wydania = 2019;
            Form1.listaObiektów.listaNagrań.Add(koncert3);


            wyświetlanie.Enabled = true;
            sortowanie.Enabled = true;
        }
    }
}
