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

namespace Mitarbeiter_Erfassen
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

        private void auswahlBetriebsmittel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = auswahlBetriebsmittel.SelectedItem.ToString();
            ansichtBetriebsmittel.Items.Add(item.Substring(item.IndexOf(":")+2));
        }
    }

    
    
    
    class Mitarbeiter
    {
        //Felder
        private string Nachname;
        private string Vorname;
        private string Abteilung;
        private string Geschlecht;
        private List<string> Arbeitsmittel;
        private bool Vorgesetzter;

        public void SetVorname(string v)
        {
            Vorname = v;
        }

        public string GetVorname()
        {
            return Vorname;
        }
    }
}
