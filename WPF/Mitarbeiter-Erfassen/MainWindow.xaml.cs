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
    public partial class MainWindow : Window
    {
        Mitarbeiter mitarbeiter;
        List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();
        
        public MainWindow()
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
            mitarbeiter = new Mitarbeiter();
            mitarbeiter.SetVorname(txtbVorname.Text);
            mitarbeiter.SetNachname(txtbNachname.Text);
            mitarbeiter.SetAbteilung(comboAbteilung.SelectedValue.ToString());
            mitarbeiter.SetVorgesetzter((bool)cbFuehrungskraft.IsChecked);
            mitarbeiter.SetGeschlecht(GetGeschlechtFromRadioButton());
            
            List<string> betriebsmittelliste = new List<string>();
            foreach (var item in ansichtBetriebsmittel.Items)
            {
                betriebsmittelliste.Add(item.ToString());
            }
            mitarbeiter.SetArbeitsmittel(betriebsmittelliste);
            
            mitarbeiterListe.Add(mitarbeiter);

            MessageBox.Show(mitarbeiter.ToString());
            
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

    class Betriebsmittel
    {
        //Klassenvariablen
        public static List<Betriebsmittel> BetriebsmittelListe = new List<Betriebsmittel>()
        {
            new Betriebsmittel(){ name = "Notebook", Wert = 2399.99M},
            new Betriebsmittel(){ name = "Werkzeugkasten", Wert = 499.98M},
            new Betriebsmittel(){ name = "Schreibutensilien", Wert = 98.00M}
        };

        // Literal-Suffixe
        // double = d,D
        // float = f,F
        // long = l,L zb. 2345736L

        // Felder, Instanzvariablen
        private string name;
        private decimal _wert;

        //Methoden, Instanzmethoden
        public decimal Wert //Properties, Eigenschaften
        {
            set { _wert = value; }
        }
        public void SetWert(decimal wert) // Methode
        {
            _wert = wert;
        }
        public decimal GetWert()
        {
            return _wert;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return name + ": " + _wert.ToString() + "€";
        }
    }

    class Mitarbeiter
    {
        //Attribute, Felder
        //Klassenvariable
        public static List<string> Abteilungen = new List<string>() { "HR","Lager","Produktion","Verwaltung","IT","Einkauf","Verkauf"};

        //Instanzvariable
        private string nachname;
        private string vorname;
        private string abteilung;
        private string geschlecht;
        private List<string> arbeitsmittel;
        private bool vorgesetzter;


        //Operationen, Methoden
        public override string ToString()
        {
            return $"Name: {nachname}, {vorname}\r\nGeschlecht: {geschlecht}\r\nIst Vorgesetzter: {vorgesetzter}\r\nAbteilung:{abteilung}";
        }

        public void SetVorgesetzter(bool vorgesetzter)
        {
            this.vorgesetzter = vorgesetzter;
        }
        public bool GetVorgesetzter()
        {
            return vorgesetzter;
        }

        public void SetArbeitsmittel(List<string> arbeitsmittel)
        {
            this.arbeitsmittel = arbeitsmittel;
        }
        public List<string> GetArbeitsmittel()
        {
            return arbeitsmittel;
        }

        public void SetGeschlecht(string geschlecht)
        {
            this.geschlecht = geschlecht;
        }
        public string GetGeschlecht()
        {
            return geschlecht;
        }

        public void SetAbteilung(string abteilung)
        {
            this.abteilung = abteilung;
        }
        public string GetAbteilung()
        {
            return abteilung;
        }

        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }
        public string GetVorname()
        {
            return vorname;
        }

        public void SetNachname(string nachname)
        {
            this.nachname = nachname;
        }
        public string GetNachname()
        {
            return nachname;
        }
    }
}
