using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Rechner
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

        private void btnClicked(object sender, RoutedEventArgs e)
        {
            string buttonName = (sender as Button).Name;
            Debug.WriteLine($"Button {buttonName} clicked!");
            switch (buttonName)
            {
                case "btn0":
                    txtboxResult.Text += "0";
                    break;
                case "btn1":
                    txtboxResult.Text += "1";
                    break;
            }
        }
    }
}
