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
    public partial class Form1 : Form
    {
        public  List<Nagranie> listaNagrań = new List<Nagranie>();

        public static Form1 listaObiektów { get; private set; }
        public Form1()
        {
           
            InitializeComponent();
            listaObiektów = this;
        }
       
        public int Ilosc_Sztuk()
        { int suma = 0;
           foreach (Nagranie n in Form1.listaObiektów.listaNagrań)
            {
                suma += n.ilosc_sztuk;
            }
            return suma;
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            this.Visible = false;
            FilmFormatka form1 = new FilmFormatka();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            KoncertFormatka form2 = new KoncertFormatka();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FunkcjeOperatorowe funkcje = new FunkcjeOperatorowe();
            funkcje.StartPosition = FormStartPosition.CenterScreen;
            funkcje.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ListaObiektów form3 = new ListaObiektów(this);
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.Show();
        }

        private void InfoObiekty_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InformacjeObiekty info = new InformacjeObiekty();
            info.StartPosition = FormStartPosition.CenterScreen;
            info.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {      
            this.label2.Location = new Point(80, 115);
            label2.Text = "Ten przycisk otwiera formatke do dodawania koncertów";
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.label2.Location = new Point(320, 115);
            label2.Text = "Ten przycisk otwiera formatke do dodawania filmów";
            label2.Visible = true;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            this.label2.Location = new Point(80, 205);
            label2.Text = "Ten przycisk otwiera formatke do przeglądanie obiektów";
            label2.Visible = true;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.label2.Location = new Point(270, 205);
            label2.Text = "Ten przycisk otwiera formatke do zilustrowania funkcji operatorowych";
            label2.Visible = true;
        }

        private void InfoObiekty_MouseHover(object sender, EventArgs e)
        {
            this.label2.Location = new Point(60, 300);
            label2.Text = "Ten przycisk otwiera formatke do przeglądania/sortowania informacji o obiektach";
            label2.Visible = true;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.label2.Location = new Point(450, 300);
            label2.Text = "Ten przycisk wyłącza program";
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BazaDanych form6 = new BazaDanych();
            form6.StartPosition = FormStartPosition.CenterScreen;
            form6.Show();
        }
    }
}
