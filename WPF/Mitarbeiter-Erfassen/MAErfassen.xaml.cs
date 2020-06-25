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

namespace Mitarbeiter_Erfassen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MAErfassen : Window
    {
        Mitarbeiter mitarbeiter;
        //List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

        public MAErfassen()
        {
            InitializeComponent();
            comboAbteilung.ItemsSource = Mitarbeiter.Abteilungen;
            auswahlBetriebsmittel.ItemsSource = Betriebsmittel.BetriebsmittelListe;
        }

        private void auswahlBetriebsmittel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string item = auswahlBetriebsmittel.SelectedItem.ToString();
            //Debug.WriteLine(item);
            //ansichtBetriebsmittel.Items.Add(item.Substring(item.IndexOf(":")+2));
            ansichtBetriebsmittel.Items.Add(auswahlBetriebsmittel.SelectedItem);

            Betriebsmittel b = (Betriebsmittel)auswahlBetriebsmittel.SelectedItem;
            Debug.WriteLine(b.GetName() + " --> " + b.GetWert());
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            //Prüfen, ob combobox Wert enthält
            if (comboAbteilung.SelectedItem == null)
            {
                MessageBox.Show("Abteilung fehlt!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            #region Setzen der Mitarbeiterwerte
            mitarbeiter = new Mitarbeiter();
            mitarbeiter.SetVorname(txtbVorname.Text);
            mitarbeiter.SetNachname(txtbNachname.Text);
            mitarbeiter.SetAbteilung(comboAbteilung.SelectedItem.ToString());
            mitarbeiter.SetVorgesetzter((bool)cbFuehrungskraft.IsChecked);
            mitarbeiter.SetGeschlecht(GetGeschlechtFromRadioButton());
            #endregion

            #region Erstellen der Arbeitsmittelliste aus der ListBox und in mitarbeiter speichern

            List<Betriebsmittel> temporäreBetriebsmittellisteHelper = new List<Betriebsmittel>();
            foreach (Betriebsmittel item in ansichtBetriebsmittel.Items)
            {
                temporäreBetriebsmittellisteHelper.Add(item);
            }
            mitarbeiter.SetArbeitsmittel(temporäreBetriebsmittellisteHelper);

            #endregion

            #region mitarbeiter der Mitarbeiterliste hinzufügen
            Mitarbeiter.MitarbeiterListe.Add(mitarbeiter);
            #endregion

            #region Ausgabe des gespeicherten Mitarbeiters in die Ausgabekonsole
            //MessageBox.Show(mitarbeiter.ToString());
            Debug.WriteLine(mitarbeiter.ToString() + Environment.NewLine);
            foreach (Betriebsmittel item in mitarbeiter.GetArbeitsmittel())
            {
                Debug.WriteLine(item.GetName() + ", " + item.GetWert());
            }
            #endregion
        }

        private string GetGeschlechtFromRadioButton()
        {
            if ((bool)rbW.IsChecked)
                return "w";
            else if ((bool)rbM.IsChecked)
                return "m";
            else
                return "d";
        }
    }
}
