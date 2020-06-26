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
            Mitarbeiter ma = new Mitarbeiter();
            ma.SetVorname("Mathias");
            ma.SetNachname("Beckmann");
            ma.SetGeschlecht("männlich");
            ma.SetVorgesetzter(false);
            ma.SetAbteilung("IT");
            ma.SetArbeitsmittel(new List<Betriebsmittel>()
            {
                new Betriebsmittel(){Name="Notebook",Wert=2599.90M},
                new Betriebsmittel(){Name="Schreibutensilien",Wert=99.90M}
            });
            Mitarbeiter.MitarbeiterListe.Add(ma);
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (pos > 0)
                pos--;
            MaAnzeigen();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            MAErfassen maErfassen = new MAErfassen();
            maErfassen.ShowDialog();
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            /*
             index | MA-Objekte | pos
             0     | Mathias    | 0
                                | 1
             */


            if (pos < Mitarbeiter.MitarbeiterListe.Count - 1 /* Anzahl Mitarbeiter*/)
                pos++;
            MaAnzeigen();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ersten MA der Mitarbeiterliste anzeigen lassen
            if (Mitarbeiter.MitarbeiterListe.Count > 0)
            {
                MaAnzeigen();
            }
        }

        private void MaAnzeigen()
        {
            Debug.WriteLine("pos: " + pos);
            Mitarbeiter m = Mitarbeiter.MitarbeiterListe[pos];
            lblMaName.Content = m.GetNachname() + ", " + m.GetVorname();
            lblMAGeschlecht.Content = m.GetGeschlecht();
            lblMAAbteilung.Content = m.GetAbteilung();
            lbMABetriebsmittel.ItemsSource = m.GetArbeitsmittel();
        }
    }
}
