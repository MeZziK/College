namespace Grzegorz_Dudek__Wypożyczalnia_filmów
{
    partial class ListaObiektów
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.obiekty = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Usuwanie = new System.Windows.Forms.Button();
            this.Ilość_sztuk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Poprzedni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "Następny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 46);
            this.button3.TabIndex = 21;
            this.button3.Text = "Powrót";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(143, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 46);
            this.button4.TabIndex = 22;
            this.button4.Text = "Wypisz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // obiekty
            // 
            this.obiekty.FormattingEnabled = true;
            this.obiekty.ItemHeight = 16;
            this.obiekty.Location = new System.Drawing.Point(462, 18);
            this.obiekty.Name = "obiekty";
            this.obiekty.Size = new System.Drawing.Size(326, 420);
            this.obiekty.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(656, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 87);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Zapisz
            // 
            this.Zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zapisz.Location = new System.Drawing.Point(12, 201);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(260, 49);
            this.Zapisz.TabIndex = 25;
            this.Zapisz.Text = "Zapisz listę do pliku";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wczytaj.Location = new System.Drawing.Point(12, 256);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(260, 49);
            this.Wczytaj.TabIndex = 26;
            this.Wczytaj.Text = "Wczytaj listę z pliku";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Usuwanie
            // 
            this.Usuwanie.Enabled = false;
            this.Usuwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuwanie.Location = new System.Drawing.Point(12, 311);
            this.Usuwanie.Name = "Usuwanie";
            this.Usuwanie.Size = new System.Drawing.Size(444, 75);
            this.Usuwanie.TabIndex = 27;
            this.Usuwanie.Text = "Usuń obiekt wyświetlony na liście";
            this.Usuwanie.UseVisualStyleBackColor = true;
            this.Usuwanie.Click += new System.EventHandler(this.Usuwanie_Click);
            // 
            // Ilość_sztuk
            // 
            this.Ilość_sztuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ilość_sztuk.Location = new System.Drawing.Point(188, 392);
            this.Ilość_sztuk.Name = "Ilość_sztuk";
            this.Ilość_sztuk.Size = new System.Drawing.Size(268, 46);
            this.Ilość_sztuk.TabIndex = 28;
            this.Ilość_sztuk.Text = "Sprawdź ilość sztuk";
            this.Ilość_sztuk.UseVisualStyleBackColor = true;
            this.Ilość_sztuk.Click += new System.EventHandler(this.button5_Click);
            // 
            // ListaObiektów
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ilość_sztuk);
            this.Controls.Add(this.Usuwanie);
            this.Controls.Add(this.Wczytaj);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obiekty);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ListaObiektów";
            this.Text = "ListaObiektów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox obiekty;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Usuwanie;
        private System.Windows.Forms.Button Ilość_sztuk;
    }
}