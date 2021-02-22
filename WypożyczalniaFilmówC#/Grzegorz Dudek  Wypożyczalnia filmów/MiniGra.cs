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
    public partial class MiniGra : Form
    {
        int i = 1;
        int ticks = 0;
        public MiniGra()
        {
            InitializeComponent();
            label1.Text = "Gra polega na jak najszybszym najechaniu kursorem myszki, na pojawiające się przyciski";
            button3.Location = new Point(800, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            Random y = new Random();

            Point pt = new Point(int.Parse(x.Next(10,900).ToString()), int.Parse(y.Next(10,500).ToString()));
            
            this.button2.Location = pt;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            timer2.Start();
            button3.Visible = false;
            
           

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Random x = new Random();
            Random y = new Random();
            Point pt = new Point(int.Parse(x.Next(900).ToString()), int.Parse(y.Next(500).ToString()));
            switch(i)
            {
                case 1: this.button2.Location = pt; i++;  break;
                case 2: this.button2.Location = pt; i++;  break;
                case 3: this.button2.Location = pt; i++;  break;
                case 4: this.button2.Location = pt; i++; break;
                case 5: this.button2.Location = pt; i++; break;
                case 6: this.button2.Location = pt; i++; break;
                case 7: this.button2.Location = pt; i++; break;
                case 8: this.button2.Location = pt; i++; break;
                case 9: this.button2.Location = pt; i++; break;
                case 10: this.button2.Location = pt; i++; timer2.Stop();MessageBox.Show("Twój wynik to: " + ticks + "s");button2.Visible = false;button3.Visible = true; break;


            }

        }
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ticks.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;
        }
    }
}
