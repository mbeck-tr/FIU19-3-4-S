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

namespace ErstesWPFProjekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBox.Text = "Bitte Button klicken!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3. Button geklickt!!!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nachricht = txtBox.Text;
            MessageBox.Show("Inhalt der Textbox ist: " + nachricht);
        }

        private void zweiterButton_Click(object sender, RoutedEventArgs e)
        {
            Zweitfenster zf = new Zweitfenster();
            zf.ShowDialog();
            zweiterButton.Content = "zeigt Zweitfenster an";
        }
    }
}
