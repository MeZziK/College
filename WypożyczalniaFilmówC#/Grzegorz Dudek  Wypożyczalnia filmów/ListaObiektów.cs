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

namespace Grzegorz_Dudek__Wypożyczalnia_filmów
{
    public partial class ListaObiektów : Form
    {   int i = 0;
        private readonly Form1 _form1;
        public ListaObiektów(Form1 form1)
        {
            
            InitializeComponent();
            this._form1 = form1;
            if (Form1.listaObiektów.listaNagrań.Count != 0)
            {
                button4.Enabled = true;
                button2.Enabled = true;
              
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            i--;
            if(i==0)
            {
                button1.Enabled = false;
            }
            button2.Enabled = true;
            if (Form1.listaObiektów.listaNagrań.Count != 0)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {   if (Form1.listaObiektów.listaNagrań.Count != 0)
            {
                obiekty.Items.Clear();              
                Form1.listaObiektów.listaNagrań[i].Write(obiekty);
                pictureBox1.Image = Form1.listaObiektów.listaNagrań[i].picture;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                button4.Enabled = false;
                if (Form1.listaObiektów.listaNagrań.Count() != 0)
                {
                    Usuwanie.Enabled = true;
                }
            }
          
            
        }

        private void Obiekty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.listaObiektów.listaNagrań.Count != 0)
            {
                button4.Enabled = true;
            }
            if (Form1.listaObiektów.listaNagrań.Count -1 > i)
            {
                button4.Enabled = true; 
            }
            else
            {
                button4.Enabled = false;
                button2.Enabled = false;
            }
            i++;
            button1.Enabled = true;
            

        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter= "TXT files|*.txt";
                saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                foreach (Nagranie n in Form1.listaObiektów.listaNagrań)
                {
                    n.Zapisz_do_pliku(sw);
                    
                }
                sw.Close();
            }

        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.RestoreDirectory = true;
            Koncert k;
            Film f;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while(!sr.EndOfStream)
                {

                    string nazwaKlasy = sr.ReadLine();
                    if(nazwaKlasy== "Grzegorz_Dudek__Wypożyczalnia_filmów.Koncert")
                    {
                        k = new Koncert();
                        k.Odczytaj_z_pliku(sr);
                        Form1.listaObiektów.listaNagrań.Add(k);
                        if(Form1.listaObiektów.listaNagrań.Count()>1)
                        {
                            button2.Enabled = true;
                        }
                        if (Form1.listaObiektów.listaNagrań.Count() > 0)
                        {
                            button4.Enabled = true;
                        }
                        /*if (k.ścieżka != "")
                        {
                            k.picture = new Bitmap(k.ścieżka);
                            pictureBox1.Image = k.picture;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }*/


                    }
                    if (nazwaKlasy == "Grzegorz_Dudek__Wypożyczalnia_filmów.Film")
                    {
                        f = new Film();
                        f.Odczytaj_z_pliku(sr);
                        Form1.listaObiektów.listaNagrań.Add(f);
                        if (Form1.listaObiektów.listaNagrań.Count() > 1)
                        {
                            button2.Enabled = true;
                        }
                        if (Form1.listaObiektów.listaNagrań.Count() > 0)
                        {
                            button4.Enabled = true;
                        }
                    }
                }
                sr.Close();
               
                
                    MessageBox.Show("Liczba nagrań na liście: " + Form1.listaObiektów.listaNagrań.Count());
                   /* foreach (Nagranie n in Form1.listaObiektów.listaNagrań)
                    {
                        pictureBox1.Visible = false;
                        n.Write(obiekty);
                        if (Form1.listaObiektów.listaNagrań.Count() > 1)
                        {
                            obiekty.Items.Add("");
                        }
                    }*/
                
                
            }
        }
        
        
        private void Usuwanie_Click(object sender, EventArgs e)
        {   if (Form1.listaObiektów.listaNagrań.Count() != 0)
            {   
                button4.Enabled = true;
                obiekty.Items.Clear();
                Form1.listaObiektów.listaNagrań.RemoveAt(i);
                if(Form1.listaObiektów.listaNagrań.Count==0)
                {
                    button4.Enabled = false;
                    Usuwanie.Enabled = false;
                }
                i = 0;
                button1.Enabled = false;
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Łączna liczba nagrań do wypożyczenia wynosi: "+this._form1.Ilosc_Sztuk().ToString());
        }
    }
}
