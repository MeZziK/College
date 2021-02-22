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
    public partial class BazaDanych : Form
    {
        int i = 0;
        public BazaDanych()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BazaDanych_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'nagraniaData.Filmy' . Możesz go przenieść lub usunąć.
            this.filmyTableAdapter.Fill(this.nagraniaData.Filmy);
            nagraniaDataBindingSource.DataSource = this.nagraniaData.Filmy;

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            i = 0;
            Edytuj.Enabled = false;
            button1.Enabled = false;
            nagraniaDataBindingSource.DataSource = this.nagraniaData.Filmy;
            Anuluj.Enabled = true;
            Zapisz.Enabled = false;
            Szukaj.Enabled = false;
            int j=dataGridView1.RowCount;
            label1.Visible = true;
            textBox1.Visible = true;
            this.nagraniaData.Filmy.AddFilmyRow(this.nagraniaData.Filmy.NewFilmyRow()); 
            Zatwierdź.Enabled = true;
            dataGridView1.Rows[j].Cells[0].Selected = true;
            label1.Text = "Podaj tytuł";
            dodaj.Enabled = false;
            dataGridView1.Enabled = false;
            numericUpDown1.Minimum = 0;
            numericUpDown2.Minimum = 0;
            numericUpDown3.Minimum = 0;
            numericUpDown4.Minimum = 0;
            numericUpDown5.Minimum = 0;
            numericUpDown6.Minimum = 0;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;


        }

        private void Zatwierdź_Click(object sender, EventArgs e)
        { i++;
            
            int j = dataGridView1.RowCount;
            switch (i)
            {
                case 1: textBox1.Focus(); if (textBox1.Text == "") { label1.Text = "Tytuł jest wymagany"; i--; } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj reżysera"; dataGridView1.Rows[j - 1].Cells[1].Selected = true; textBox1.Visible = false; textBox2.Visible = true; textBox2.Focus(); }; break;
                case 2: if (textBox2.Text == "") { label1.Text = "Nie podałeś reżysera"; i--; textBox2.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj wytwórnie"; dataGridView1.Rows[j - 1].Cells[2].Selected = true; textBox2.Visible = false; textBox3.Visible = true; textBox3.Focus(); }; break;
                case 3:  if (textBox3.Text == "") { label1.Text = "Nie podałeś wytwórni"; i--; textBox3.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj kraj_produkcji"; dataGridView1.Rows[j - 1].Cells[3].Selected = true; textBox3.Visible = false; textBox4.Visible = true; textBox4.Focus(); }; break;
                case 4:  if (textBox4.Text == "") { label1.Text = "Nie podałeś kraju produkcji"; i--; textBox4.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj rok wydania"; dataGridView1.Rows[j - 1].Cells[4].Selected = true; textBox4.Visible = false; numericUpDown1.Visible = true; numericUpDown1.Maximum = 2021; numericUpDown1.Minimum = 1960; numericUpDown1.Focus(); numericUpDown1.ResetText(); }; break;
                case 5:  if (numericUpDown1.Value<=1960||numericUpDown1.Value>=2021) { label1.Text = "Podałeś zły rok wydania; min: 1961, max 2020: "; i--; numericUpDown1.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj ilość sztuk"; dataGridView1.Rows[j - 1].Cells[5].Selected = true; numericUpDown2.Maximum = 101; numericUpDown2.Minimum = 0; numericUpDown1.Visible = false; numericUpDown2.Visible = true; numericUpDown2.Focus(); numericUpDown2.ResetText();numericUpDown1.Value = 1960; }; break;
                case 6: if (numericUpDown2.Value <= 0 || numericUpDown2.Value >= 101) { label1.Text = "Podałeś złą ilość sztuk; min: 1, max 100: "; i--; numericUpDown2.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj dlugość nagrania"; dataGridView1.Rows[j - 1].Cells[6].Selected = true; numericUpDown3.Maximum = 301; numericUpDown3.Minimum = 4; numericUpDown2.Visible = false; numericUpDown3.Visible = true; numericUpDown3.Focus(); numericUpDown3.ResetText(); numericUpDown2.Value = 0; }; break;
                case 7: if (numericUpDown3.Value <= 4 || numericUpDown3.Value >= 301) { label1.Text = "Podałeś złą długość nagrania; min: 5, max 300: "; i--; numericUpDown3.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj kategoria wiekową"; dataGridView1.Rows[j - 1].Cells[7].Selected = true; numericUpDown4.Maximum = 19; numericUpDown4.Minimum = 2; numericUpDown3.Visible = false; numericUpDown4.Visible = true; numericUpDown4.Focus(); numericUpDown4.ResetText(); numericUpDown3.Value = 4; }; break;
                case 8: if (numericUpDown4.Value <= 2 || numericUpDown4.Value >= 19) { label1.Text = "Podałeś złą kategorie wiekową; min: 3, max 18: "; i--; numericUpDown4.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj cenę wypożyczenia"; dataGridView1.Rows[j - 1].Cells[8].Selected = true; numericUpDown5.Maximum = 101; numericUpDown5.Minimum = 4; numericUpDown4.Visible = false; numericUpDown5.Visible = true; numericUpDown5.Focus(); numericUpDown5.ResetText(); numericUpDown4.Value = 2; }; break;
                case 9: if (numericUpDown5.Value <= 4 || numericUpDown5.Value >= 101) { label1.Text = "Podałeś złą cene wypożyczenia; min: 5, max 100: "; i--; numericUpDown5.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj maksymalny czas wypożyczenia"; dataGridView1.Rows[j - 1].Cells[9].Selected = true; numericUpDown6.Maximum = 8; numericUpDown6.Minimum = 1; numericUpDown5.Visible = false; numericUpDown6.Visible = true; numericUpDown6.Focus(); numericUpDown6.ResetText(); numericUpDown5.Value = 4; }; break;
                case 10: if (numericUpDown6.Value <= 1 || numericUpDown6.Value >= 8) { label1.Text = "Podałeś zły czas wypożyczenia; min: 2, max 7: "; i--; numericUpDown6.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj gatunek"; dataGridView1.Rows[j - 1].Cells[11].Selected = true;  numericUpDown6.Visible = false; textBox5.Visible = true; textBox5.Focus(); numericUpDown6.Value = 1; }; break;
                case 11: if (textBox5.Text=="") { label1.Text = "Nie podałeś gatunku"; i--;textBox5.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj rodzaj nośnika:"; dataGridView1.Rows[j - 1].Cells[12].Selected = true; textBox5.Visible= false; textBox6.Visible = true; textBox6.Focus(); }; break;
                case 12: if (textBox6.Text == "") { label1.Text = "Nie podałeś rodzaju nośnika"; i--; textBox6.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj lokalizacje na półce: "; dataGridView1.Rows[j - 1].Cells[13].Selected = true; textBox6.Visible = false; textBox7.Visible = true; textBox7.Focus(); }; break;
                case 13: if (textBox7.Text == "") { label1.Text = "Nie podałeś lokalizacji na półce"; i--; textBox7.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj wersje okładki:"; dataGridView1.Rows[j - 1].Cells[14].Selected = true; textBox7.Visible = false; textBox8.Visible = true; textBox8.Focus(); }; break;
                case 14: if (textBox8.Text == "") { label1.Text = "Nie podałeś wersji okładki "; i--; textBox8.Focus(); } else { nagraniaDataBindingSource.MoveLast(); label1.Text = "Podaj datę dodania"; dataGridView1.Rows[j - 1].Cells[10].Selected = true; textBox8.Visible = false; dateTimePicker1.Visible = true; dateTimePicker1.Focus(); }; break;
                case 15: nagraniaDataBindingSource.MoveLast(); dataGridView1.Rows[j - 1].Cells[11].Selected=true; label1.Text = "Ukończyłeś dodawanie, kliknij przycisk zapisz";dodaj.Enabled = false;Zatwierdź.Enabled = false;dateTimePicker1.Visible = false;i = 0; Zapisz.Enabled = true;  break;
                case 17: nagraniaDataBindingSource.MoveLast(); dataGridView1.Rows[j - 1].Cells[11].Selected = true;  dodaj.Enabled = true; Zatwierdź.Enabled = false; dateTimePicker1.Visible = false; i = 0; Zapisz.Enabled = true; Edytuj.Enabled = true;Szukaj.Enabled = true;button1.Enabled = true;label1.Visible = false;Anuluj2.Enabled = false; break;


            }
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {   if (dataGridView1.RowCount > 0)
            {
                var query = from o in this.nagraniaData.Filmy
                            where o.Tytuł.Contains(Szukanie.Text) || o.Reżyser.Contains(Szukanie.Text)
                            select o;

                nagraniaDataBindingSource.DataSource = query.ToList();
            }
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Edytuj.Enabled = true;
            dodaj.Enabled = true;
            Szukaj.Enabled = true;
            try {
              nagraniaDataBindingSource.EndEdit();
               filmyTableAdapter.Update(this.nagraniaData.Filmy);
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nagraniaDataBindingSource.ResetBindings(false);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            button1.Enabled = true;
            Anuluj.Enabled = false;
            dataGridView1.Enabled = true;
            
            
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            Edytuj.Enabled = true;
            nagraniaDataBindingSource.ResetBindings(false);
            dodaj.Enabled = true;
            Szukaj.Enabled = true;
            Zapisz.Enabled = true;
            Zatwierdź.Enabled = false;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown4.Visible = false;
            numericUpDown5.Visible = false;
            numericUpDown6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            label1.Text = "";
            i = 0;
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Anuluj.Enabled = false;
            button1.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            nagraniaDataBindingSource.ResetBindings(false);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Enabled = true;
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            }
        }

        private void Powrót_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.listaObiektów.Visible = true;
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true; ;
            Zapisz.Enabled = false;
            button1.Enabled = false;
            Szukaj.Enabled = false;
            label1.Visible = true;
            dodaj.Enabled = false;
            Zatwierdź.Enabled = true;
            i = dataGridView1.CurrentCell.ColumnIndex;
           
            if(i>10)
            {
                i -= 1;
            }
            if (i == 10)
            {
                i = 16;
            }
            // Zatwierdź_Ed.Visible = true;
            Anuluj2.Visible = true;
            Edytuj.Enabled = false;
            switch(i)
            {
                case 0: label1.Text = "Podaj tytuł"; textBox1.Visible = true;textBox1.Focus(); break;
                case 1: label1.Text = "Podaj reżysera";textBox2.Visible = true;textBox1.Focus(); break;
                case 2: label1.Text = "Podaj wytwórnie";textBox3.Visible = true;textBox1.Focus(); break;
                case 3: label1.Text = "Podaj kraj produkcji "; textBox4.Visible = true;textBox4.Focus(); break;
                case 4: label1.Text = "Podaj rok wydania";numericUpDown1.Visible = true;break;
                case 5: label1.Text = "Podaj ilość sztuk"; numericUpDown2.Visible = true;break;
                case 6: label1.Text = "Długość nagrania";numericUpDown3.Visible = true;break;
                case 7: label1.Text = "Podaj kategorię wiekową"; numericUpDown4.Visible = true; break;
                case 8: label1.Text = "Podaj cenę wypożyczenia"; numericUpDown5.Visible = true; break;
                case 9: label1.Text = "Podaj czas wypożyczenia"; numericUpDown6.Visible = true; break;
                case 10: label1.Text = "Podaj gatunek"; textBox5.Visible = true; break;
                case 11: label1.Text = "Podaj rodzaj nośnika"; textBox6.Visible = true; break;
                case 12: label1.Text = "Podaj lokalizacje na półce"; textBox7.Visible = true; break;
                case 13: label1.Text = "Podaj wersje okładki"; textBox8.Visible = true; break;
                case 16:label1.Text = "Podaj datę"; dateTimePicker1.Visible = true; break;



            }
         
           
        }

        

        private void Anuluj2_Click(object sender, EventArgs e)
        {
            Zatwierdź.Enabled = false;
            label1.Visible = false;
            nagraniaDataBindingSource.ResetBindings(false);
           
            Anuluj2.Visible = false;
            Edytuj.Enabled = true;
            dodaj.Enabled = true;
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;
            numericUpDown4.Visible = false;
            numericUpDown5.Visible = false;
            numericUpDown6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            Zapisz.Enabled = true;
            button1.Enabled = true;
            Szukaj.Enabled = true;
            dataGridView1.Enabled = true;

        }
    }
}
