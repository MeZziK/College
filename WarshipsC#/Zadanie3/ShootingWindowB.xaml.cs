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
    /// Logika interakcji dla klasy ShootingWindowB.xaml
    /// </summary>
    public partial class ShootingWindowB : Window
    {
     
        public static ShootingWindowB windowB;

        public ShootingWindowB()
        {
            InitializeComponent();
            
            this.IsEnabled = false;
            windowB = this;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Zadanie3.ShootingWindowA.windowA.ButtonClick(sender, e);
            Zadanie3.ShootingWindowA.windowA.IsEnabled = true;
            this.IsEnabled = false;
            button.IsEnabled = false;
        }
    }
}
