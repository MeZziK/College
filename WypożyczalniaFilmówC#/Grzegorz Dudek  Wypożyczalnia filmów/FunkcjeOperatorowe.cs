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
    public partial class FunkcjeOperatorowe : Form
    {
        Film film = new Film();
        Film film_2 = new Film();
        




        public FunkcjeOperatorowe()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            film.tytul = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            film_2.tytul = textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            if(film==film_2)
            {
                label5.Text = "Tytuły są takie same";
            }
            if(film!=film_2)
            {
                label5.Text = "Tytuły są różne";
            }

            label5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Film film3= film + film_2;
            label8.Text = film3.tytul;
            label8.Visible = true;
         
        }
    }
}
