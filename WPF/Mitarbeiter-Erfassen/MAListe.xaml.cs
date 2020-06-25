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

namespace Mitarbeiter_Erfassen
{
    /// <summary>
    /// Interaktionslogik für MAListe.xaml
    /// </summary>
    public partial class MAListe : Window
    {
        int pos = 0;
        public MAListe()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (pos > 0)
                pos--;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            MAErfassen maErfassen = new MAErfassen();
            maErfassen.ShowDialog();
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            if (pos < Mitarbeiter.MitarbeiterListe.Count /* Anzahl Mitarbeiter*/)
                pos++;
        }
    }
}
