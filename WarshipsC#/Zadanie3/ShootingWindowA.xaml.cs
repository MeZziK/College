using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zadanie3
{
    /// <summary>
    /// Logika interakcji dla klasy ShootingWindow.xaml
    /// </summary>
    public partial class ShootingWindowA : Window
    {

        public static ShootingWindowA windowA;
        string[,] tabGraczB;
        string[,] tabGraczA;
        int rowIndex;
        int columnIndex;
        int licznikA = 9;
        int licznikB = 9;
        bool turnA = true;

        public ShootingWindowA(string[,] tabGraczB,string[,] tabGraczA)
        {
            InitializeComponent();
            this.tabGraczB = tabGraczB;
            this.tabGraczA = tabGraczA;
            windowA = this;
        }

        //funkcja sprawdzająca czy trafiono statek odpowiedniego gracza

        void Check(Button button)
        {
            
            button.FontSize = 30;
            if (turnA)
            {
                if(tabGraczB[rowIndex,columnIndex]!=null)
                {
                    if (tabGraczB[rowIndex, columnIndex] == "k")
                    {
                        
                        Info.Text = "Trafiono krążownika!";
                    }
                    if (tabGraczB[rowIndex, columnIndex] == "n")
                    {
                        Info.Text = "Trafiono niszczyciela";
                    }
                    if (tabGraczB[rowIndex, columnIndex] == "z")
                    {
                        Info.Text = "Trafiono zwiadowcę";
                    }
                    licznikB--;
                    button.Content = "X";
                    button.Foreground = Brushes.Red;
                }
                else
                {
                    Info.Text = "Pudło!";
                    button.Content = ".";
                    button.Foreground = Brushes.Blue;
                }
            }
            else
            {
                if (tabGraczA[rowIndex, columnIndex] != null)
                {
                    if (tabGraczA[rowIndex, columnIndex] == "k")
                    {
                        
                        Zadanie3.ShootingWindowB.windowB.Info.Text = "Trafiono krążownika!";
                    }
                    if (tabGraczA[rowIndex, columnIndex] == "n")
                    {
                        Zadanie3.ShootingWindowB.windowB.Info.Text = "Trafiono niszczyciela";
                    }
                    if (tabGraczA[rowIndex, columnIndex] == "z")
                    {
                        Zadanie3.ShootingWindowB.windowB.Info.Text = "Trafiono zwiadowcę";
                    }                    
                    licznikA--;
                    button.Content = "X";
                    button.Foreground = Brushes.Red;
                }
                else
                {
                    Zadanie3.ShootingWindowB.windowB.Info.Text = "Pudło!";
                    button.Content = ".";
                    button.Foreground = Brushes.Blue;
                }
            }
        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            rowIndex = Grid.GetRow(button);
            columnIndex = Grid.GetColumn(button);
            Check(button);
            turnA = !turnA;
            if(turnA)
            {
                Info.Text = "Wybierz cel";
            }
            else
            {
                Zadanie3.ShootingWindowB.windowB.Info.Text = "Wybierz cel";
            }
            button.IsEnabled = false;
            Zadanie3.ShootingWindowB.windowB.IsEnabled = true;
            this.IsEnabled = false;
            if(licznikB==0)
            {
                MessageBox.Show("Gracz A wygrał!");
                MainWindow main = new MainWindow();
                Zadanie3.ShootingWindowB.windowB.Close();
                Zadanie3.GraczB.graczB.Close();
                Zadanie3.GraczA.graczA.Close();
                this.Close();
                main.Show();
            }
            if(licznikA==0)
            {
                MessageBox.Show("Gracz B wygrał!");
                Zadanie3.ShootingWindowB.windowB.Close();
                Zadanie3.GraczB.graczB.Close();
                Zadanie3.GraczA.graczA.Close();
                this.Close();
                MainWindow main = new MainWindow();
                main.Show();
                
            }
          
        }
    }
}
