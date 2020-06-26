using System.Collections.Generic;

namespace Mitarbeiter_Erfassen
{
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
            get { return _wert; }
        }

        public string Name { get => name; set => name = value; }

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
}
