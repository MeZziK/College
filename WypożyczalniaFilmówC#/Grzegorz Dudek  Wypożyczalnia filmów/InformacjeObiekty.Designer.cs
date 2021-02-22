namespace Grzegorz_Dudek__Wypożyczalnia_filmów
{
    partial class InformacjeObiekty
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.wyświetlanie = new System.Windows.Forms.Button();
            this.sortowanie = new System.Windows.Forms.Button();
            this.powrót = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.przykładowe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(322, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 420);
            this.listBox1.TabIndex = 0;
            // 
            // wyświetlanie
            // 
            this.wyświetlanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wyświetlanie.Location = new System.Drawing.Point(12, 31);
            this.wyświetlanie.Name = "wyświetlanie";
            this.wyświetlanie.Size = new System.Drawing.Size(258, 37);
            this.wyświetlanie.TabIndex = 1;
            this.wyświetlanie.Text = "Wyświetl informacje";
            this.wyświetlanie.UseVisualStyleBackColor = true;
            this.wyświetlanie.Click += new System.EventHandler(this.wyświetlanie_Click);
            // 
            // sortowanie
            // 
            this.sortowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortowanie.Location = new System.Drawing.Point(12, 93);
            this.sortowanie.Name = "sortowanie";
            this.sortowanie.Size = new System.Drawing.Size(127, 44);
            this.sortowanie.TabIndex = 2;
            this.sortowanie.Text = "Sortuj";
            this.sortowanie.UseVisualStyleBackColor = true;
            this.sortowanie.Click += new System.EventHandler(this.sortowanie_Click);
            // 
            // powrót
            // 
            this.powrót.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powrót.Location = new System.Drawing.Point(12, 392);
            this.powrót.Name = "powrót";
            this.powrót.Size = new System.Drawing.Size(170, 46);
            this.powrót.TabIndex = 22;
            this.powrót.Text = "Powrót";
            this.powrót.UseVisualStyleBackColor = true;
            this.powrót.Click += new System.EventHandler(this.powrót_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // przykładowe
            // 
            this.przykładowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.przykładowe.Location = new System.Drawing.Point(12, 238);
            this.przykładowe.Name = "przykładowe";
            this.przykładowe.Size = new System.Drawing.Size(304, 98);
            this.przykładowe.TabIndex = 24;
            this.przykładowe.Text = "Zilustrowanie sortowania";
            this.przykładowe.UseVisualStyleBackColor = true;
            this.przykładowe.Click += new System.EventHandler(this.przykładowe_Click);
            // 
            // InformacjeObiekty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.przykładowe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrót);
            this.Controls.Add(this.sortowanie);
            this.Controls.Add(this.wyświetlanie);
            this.Controls.Add(this.listBox1);
            this.Name = "InformacjeObiekty";
            this.Text = "InformacjeObiekty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button wyświetlanie;
        private System.Windows.Forms.Button sortowanie;
        private System.Windows.Forms.Button powrót;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button przykładowe;
    }
}