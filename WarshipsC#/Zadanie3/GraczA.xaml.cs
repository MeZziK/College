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
    /// Logika interakcji dla klasy GraczA.xaml
    /// </summary>
    public partial class GraczA : Window
    {

        public static GraczA graczA;
        public GraczA()
        {
            InitializeComponent();
            graczA = this;
        }

        //ilość "części" statków
        
        int licznik = 9;

        // zmienne pomocniczne przy ustawianu statków

        int rowIndex;
        int columnIndex;
        int lastRow;
        int lastColumn;

        int krazownik1Row;
        int krazownik1Column;

        int krazownik2Row;
        int krazownik2Column;

        int niszczycielRow;
        int niszczycielColumn;

    
        int tmpX1;
        int tmpX2;
        int tmpY1;
        int tmpY2;


        public string[,] tabGraczA = new string[9, 9];          //główna tablica rozstawienia statków

        //tablice pomocniczne przy sprawdzaniu 1 kratki odstępu od innych statków

        int[] shipsX = new int[9];              
        int[] shipsY = new int[9];

        //funkcja sprawdzająca czy wybrana pozycja posiada przynajmniej jedno miejsce odstępu od innego statku

        bool Check(Button button)
       {
           
            //poszczególne if sprawdzają czy wartość indexów x i y są już na mapie
            //np chcę ustawić statek w punkcie 1,1 więc sprawdzam, czy posiadam w tablicy, już zarezerwowane punkty naokoło punktu 1,1

            for (int i = 0; i < shipsY.Length; i++)
            {
                if (columnIndex + 1 == shipsY[i]&& rowIndex  == shipsX[i])
                {
                    return false;
                }
                if (columnIndex - 1 == shipsY[i]&& rowIndex == shipsX[i])
                {
                    return false;
                }
                if (columnIndex  == shipsY[i] && rowIndex+1 == shipsX[i])
                {
                    return false;
                }
                if (columnIndex  == shipsY[i] && rowIndex -1== shipsX[i])
                {
                    
                    return false;
                }

            }
            return true;
        }

        //funkcja wpisująca w pole buttonu odpowiedni symbol i wpisująca do tablicy, współrzędne w których znajdują się statki

        void Assign(Button button, int licznik)
        {
            if (licznik == 3 || licznik == 2)
            {
                tabGraczA[rowIndex, columnIndex] = "n";
                button.Content = "🛥";
            }
            else if (licznik == 1)
            {
                tabGraczA[rowIndex, columnIndex] = "z";
                button.Content = "🚣";
            }
            else
            {
                tabGraczA[rowIndex, columnIndex] = "k";
                button.Content = "🚢";
                
            }
            button.IsEnabled = false;

            //zmienne potrzebne przy wybraniu pozycji kolejnej części danego statku

            lastRow = rowIndex;
            lastColumn = columnIndex;

        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            columnIndex= Grid.GetColumn(button);
            rowIndex= Grid.GetRow(button);
            button.FontSize = 30;

            // if, w których ustawiane są na mapie statki 

            if (licznik == 9)
            {
                Assign(button,licznik);
                licznik--;
                krazownik1Row = rowIndex;
                krazownik1Column = columnIndex;
                shipsX[0] = rowIndex;
                shipsY[0] = columnIndex;
                return;           
            }
            if(licznik==8)
            {
                if((rowIndex==lastRow+1&&columnIndex==lastColumn)||(rowIndex==lastRow-1&&columnIndex==lastColumn)||(rowIndex==lastRow&&columnIndex==lastColumn-1)||(lastRow==rowIndex&&columnIndex==lastColumn+1))
                {
                    Assign(button,licznik);
                    shipsX[1] = rowIndex;
                    shipsY[1] = columnIndex;
                    licznik--;
                    return;
                }
            }
            if(licznik==7)
            {
                if((rowIndex==krazownik1Row&&rowIndex==lastRow&&columnIndex==lastColumn-1)||(rowIndex==krazownik1Row&&columnIndex==krazownik1Column+1 && rowIndex == lastRow) || (rowIndex == krazownik1Row && columnIndex == lastColumn + 1 && rowIndex == lastRow)|| (rowIndex == krazownik1Row && columnIndex == krazownik1Column-1 && rowIndex == lastRow))
                {
                    Assign(button,licznik);
                    licznik--;
                    shipsX[2] = rowIndex;
                    shipsY[2] = columnIndex;
                    Info.Text = "Ustaw drugiego krążownika";
                    return;
                }
                if((columnIndex==krazownik1Column&&columnIndex==lastColumn&&rowIndex==lastRow-1)|| (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == krazownik1Row + 1)|| (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == lastRow + 1)|| (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == krazownik1Row - 1))
                {
                    Assign(button,licznik);
                    licznik--;
                    shipsX[2] = rowIndex;
                    shipsY[2] = columnIndex;
                    Info.Text = "Ustaw drugiego krążownika";
                    return;
                }
                
            }

            if(licznik==6)
            {
                if(Check(button)==false)
                {
                    return;
                }
                else
                {

                    Assign(button,licznik);
                    licznik--;
                    krazownik2Row = rowIndex;
                    krazownik2Column = columnIndex;
                    tmpX1 = rowIndex;
                    tmpY1 = columnIndex;
                    return;
                }
            }
            if (licznik == 5)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    if ((rowIndex == lastRow + 1 && columnIndex == lastColumn) || (rowIndex == lastRow - 1 && columnIndex == lastColumn) || (rowIndex == lastRow && columnIndex == lastColumn - 1) || (lastRow == rowIndex && columnIndex == lastColumn + 1))
                    {
                        Assign(button,licznik);
                        tmpX2 = rowIndex;
                        tmpY2 = columnIndex;
                        licznik--;
                        return;
                    }
                }
            }

            if(licznik==4)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    if ((rowIndex == krazownik2Row && rowIndex == lastRow && columnIndex == lastColumn - 1) || (rowIndex == krazownik2Row && columnIndex == krazownik2Column + 1 && rowIndex == lastRow) || (rowIndex == krazownik2Row && columnIndex == lastColumn + 1 && rowIndex == lastRow) || (rowIndex == krazownik2Row && columnIndex == krazownik1Column - 1 && rowIndex == lastRow))
                    {
                        Assign(button,licznik);
                        licznik--;

                        shipsX[3] = tmpX1;
                        shipsX[4] = tmpX2;
                        shipsY[3] = tmpY1;
                        shipsY[4] = tmpY2;
                        shipsX[5] = rowIndex;
                        shipsY[5] = columnIndex;
                        Info.Text = "Ustaw niszczyciela";
                        return;
                    }
                    if ((columnIndex == krazownik2Column && columnIndex == lastColumn && rowIndex == lastRow - 1) || (columnIndex == krazownik2Column && columnIndex == lastColumn && rowIndex == krazownik2Row + 1) || (columnIndex == krazownik2Column && columnIndex == lastColumn && rowIndex == lastRow + 1) || (columnIndex == krazownik2Column && columnIndex == lastColumn && rowIndex == krazownik2Row - 1))
                    {
                        Assign(button,licznik);
                        licznik--;
                        shipsX[3] = tmpX1;
                        shipsX[4] = tmpX2;
                        shipsY[3] = tmpY1;
                        shipsY[4] = tmpY2;
                        shipsX[5] = rowIndex;
                        shipsY[5] = columnIndex;
                        Info.Text = "Ustaw niszczyciela";
                        return;
                    }
                }
            }

            if(licznik==3)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    Assign(button,licznik);
                    licznik--;
                    niszczycielRow = rowIndex;
                    niszczycielColumn = columnIndex;
                    tmpX1 = rowIndex;
                    tmpY1 = columnIndex;
                    return;
                }
            }

            if(licznik==2)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    if ((rowIndex == lastRow + 1 && columnIndex == lastColumn) || (rowIndex == lastRow - 1 && columnIndex == lastColumn) || (rowIndex == lastRow && columnIndex == lastColumn - 1) || (lastRow == rowIndex && columnIndex == lastColumn + 1))
                    {
                        Assign(button, licznik);
                        shipsX[6] = tmpX1;
                        shipsX[7] = rowIndex;
                        shipsY[6] = tmpY1;
                        shipsY[7] = columnIndex;
                        licznik--;
                        Info.Text = "Ustaw zwiadowce";
                        return;
                    }
                }
            }

            if(licznik==1)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    //otworzenie okna gracza B i zamienienie tego okna na "mapę"
                    //funkcje w graczu B wyglądają tak samo

                    Assign(button, licznik);
                    this.IsEnabled = false;
                    Info.Text = "Gracz A";
                    GraczB _graczB = new GraczB(tabGraczA);
                    MessageBox.Show("Kolej graczaB");
                    this.Left = 0;
                    this.Top = 0;
                    this.Height = 400;
                    this.Width = 400;
                    _graczB.Show();                  
                    return;
                }
            }



        }

        //funkcja resetująca ustawianie statków 

        private void Reset(object sender, RoutedEventArgs e)
        {
            GraczA gracz = new GraczA();
            this.Close();
            gracz.Show();
        }
    }
}
