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

namespace WPF_Controls
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox1.Visibility == Visibility.Visible)
            {
                txtbox1.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtbox1.Visibility = Visibility.Visible;
            }
        }

        private void btnSteuerelemente_Click(object sender, RoutedEventArgs e)
        {
            Steuerelemente se = new Steuerelemente();
            se.ShowDialog();
        }
    }
}
