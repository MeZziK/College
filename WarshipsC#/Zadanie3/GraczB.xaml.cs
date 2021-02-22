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
    /// Logika interakcji dla klasy GraczB.xaml
    /// </summary>
    public partial class GraczB : Window
    {
        string[,] tabGraczA;
        public static GraczB graczB;

        public GraczB(string[,] tabGraczA)
        {
            InitializeComponent();
            this.tabGraczA = tabGraczA;
            graczB = this;
        }

        

        int licznik = 9;
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


        string[,] tabGraczB = new string[9, 9];
        int[] shipsX = new int[9];
        int[] shipsY = new int[9];

        bool Check(Button button)
        {

            for (int i = 0; i < shipsY.Length; i++)
            {
                if (columnIndex + 1 == shipsY[i] && rowIndex == shipsX[i])
                {
                    return false;
                }
                if (columnIndex - 1 == shipsY[i] && rowIndex == shipsX[i])
                {
                    return false;
                }
                if (columnIndex == shipsY[i] && rowIndex + 1 == shipsX[i])
                {
                    return false;
                }
                if (columnIndex == shipsY[i] && rowIndex - 1 == shipsX[i])
                {

                    return false;
                }

            }
            return true;
        }


        void Assign(Button button, int licznik)
        {
            if (licznik == 3 || licznik == 2)
            {
                tabGraczB[rowIndex, columnIndex] = "n";
                button.Content = "🛥";
            }
            else if (licznik == 1)
            {
                tabGraczB[rowIndex, columnIndex] = "z";
                button.Content = "🚣";
            }
            else
            {
                tabGraczB[rowIndex, columnIndex] = "k";
                button.Content = "🚢";

            }
            button.IsEnabled = false;
            lastRow = rowIndex;
            lastColumn = columnIndex;

        }


        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            columnIndex = Grid.GetColumn(button);
            rowIndex = Grid.GetRow(button);
            button.FontSize = 30;

            if (licznik == 9)
            {
                Assign(button, licznik);
                licznik--;
                krazownik1Row = rowIndex;
                krazownik1Column = columnIndex;
                shipsX[0] = rowIndex;
                shipsY[0] = columnIndex;
                return;
            }
            if (licznik == 8)
            {
                if ((rowIndex == lastRow + 1 && columnIndex == lastColumn) || (rowIndex == lastRow - 1 && columnIndex == lastColumn) || (rowIndex == lastRow && columnIndex == lastColumn - 1) || (lastRow == rowIndex && columnIndex == lastColumn + 1))
                {
                    Assign(button, licznik);
                    shipsX[1] = rowIndex;
                    shipsY[1] = columnIndex;
                    licznik--;
                    return;
                }
            }
            if (licznik == 7)
            {
                if ((rowIndex == krazownik1Row && rowIndex == lastRow && columnIndex == lastColumn - 1) || (rowIndex == krazownik1Row && columnIndex == krazownik1Column + 1 && rowIndex == lastRow) || (rowIndex == krazownik1Row && columnIndex == lastColumn + 1 && rowIndex == lastRow) || (rowIndex == krazownik1Row && columnIndex == krazownik1Column - 1 && rowIndex == lastRow))
                {
                    Assign(button, licznik);
                    licznik--;
                    shipsX[2] = rowIndex;
                    shipsY[2] = columnIndex;
                    Info.Text = "Ustaw drugiego krążownika";
                    return;
                }
                if ((columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == lastRow - 1) || (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == krazownik1Row + 1) || (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == lastRow + 1) || (columnIndex == krazownik1Column && columnIndex == lastColumn && rowIndex == krazownik1Row - 1))
                {
                    Assign(button, licznik);
                    licznik--;
                    shipsX[2] = rowIndex;
                    shipsY[2] = columnIndex;
                    Info.Text = "Ustaw drugiego krążownika";
                    return;
                }

            }

            if (licznik == 6)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {

                    Assign(button, licznik);
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
                        Assign(button, licznik);
                        tmpX2 = rowIndex;
                        tmpY2 = columnIndex;
                        licznik--;
                        return;
                    }
                }
            }

            if (licznik == 4)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    if ((rowIndex == krazownik2Row && rowIndex == lastRow && columnIndex == lastColumn - 1) || (rowIndex == krazownik2Row && columnIndex == krazownik2Column + 1 && rowIndex == lastRow) || (rowIndex == krazownik2Row && columnIndex == lastColumn + 1 && rowIndex == lastRow) || (rowIndex == krazownik2Row && columnIndex == krazownik1Column - 1 && rowIndex == lastRow))
                    {
                        Assign(button, licznik);
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
                        Assign(button, licznik);
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

            if (licznik == 3)
            {
                if (Check(button) == false)
                {
                    return;
                }
                else
                {
                    Assign(button, licznik);
                    licznik--;
                    niszczycielRow = rowIndex;
                    niszczycielColumn = columnIndex;
                    tmpX1 = rowIndex;
                    tmpY1 = columnIndex;
                    return;
                }
            }

            if (licznik == 2)
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

            if (licznik == 1)
            {
                if (Check(button) == false)
                {
                   
                    return;
                }
                else
                {
                        Info.Text = "Gracz B";
                        this.IsEnabled = false;
                        this.Left = 1140;
                        this.Top = 0;
                        this.Height = 400;
                        this.Width = 400;
                        Assign(button, licznik);
                    ShootingWindowA window = new ShootingWindowA(tabGraczB,tabGraczA);
                    ShootingWindowB window1 = new ShootingWindowB();
                    window.Show();
                    window1.Show();
                        return;
                    
                }
            }



        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            GraczB gracz = new GraczB(tabGraczA);
            this.Close();
            gracz.Show();
        }
    }
}
