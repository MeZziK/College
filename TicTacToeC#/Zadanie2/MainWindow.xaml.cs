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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Zadanie2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Scores scoresWindow = new Scores();
        public MainWindow()
        {
            InitializeComponent();           
            scoresWindow.Show();
            Reset();
        }
        string[,] array = new string[3, 3];
        bool checker = false;
        int licznik = 0;
        int wynik1 = 0;
        int wynik2 = 0;

        void Reset()
        {   
            licznik = 0;
            array[0, 0] = "a";
            array[0, 1] = "b";
            array[0, 2] = "c";
            array[1, 0] = "d";
            array[1, 1] = "e";
            array[1, 2] = "f";
            array[2, 0] = "g";
            array[2, 1] = "h";
            array[2, 2] = "j";
            Button1.Content = "";
            Button2.Content = "";
            Button3.Content = "";
            Button4.Content = "";
            Button5.Content = "";
            Button6.Content = "";
            Button7.Content = "";
            Button8.Content = "";
            Button9.Content = "";
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
            Button7.IsEnabled = true;
            Button8.IsEnabled = true;
            Button9.IsEnabled = true;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            licznik++;
            if (checker == false)
            {
                button.Content = "X";
                button.Foreground = Brushes.Yellow;
                Update(button);
                Check(button,checker);
                checker = true;
            }
            else
            {
                button.Content = "O";
                button.Foreground = Brushes.Purple;
                Update(button);
                Check(button,checker);
                checker = false;
            }
            
            
            
        }

      public void Check(Button button,bool checker)
        {

            button.IsEnabled = false;

            for (int i=0;i<3;i++)
            {
                if(array[i,0]==array[i,1]&& array[i, 1]==array[i, 2])
                {
                    Win();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (array[0, i] == array[1, i] && array[1, i] == array[2, i])
                {
                    Win();
                }
            }
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                Win();
            }
            if (array[2, 0] == array[1, 1] && array[1, 1] == array[0, 2])
            {
                Win();
            }

            if (licznik==9)
            {
                MessageBox.Show("Remis");
                Reset();
            }


        }

        public void Update(Button button)
        {
            array[Grid.GetRow(button), Grid.GetColumn(button)] = button.Content.ToString();           
        }

        public void Win()
        {
            if(!checker)
            {
                MessageBox.Show("Gracz zółty wygrał");
                wynik1++;
                scoresWindow.wynik1.Text = wynik1.ToString();
                Reset();
            }
            else
            {
                MessageBox.Show("Gracz fioletowy wygrał");
                wynik2++;
                scoresWindow.wynik2.Text = wynik2.ToString();
                Reset();
            }
        }
    }
}
