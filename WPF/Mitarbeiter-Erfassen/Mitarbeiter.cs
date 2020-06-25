using System.Collections.Generic;

namespace Mitarbeiter_Erfassen
{
    class Mitarbeiter
    {
        //Attribute, Felder
        //Klassenvariable
        public static List<string> Abteilungen = new List<string>() { "HR","Lager","Produktion","Verwaltung","IT","Einkauf","Verkauf"};
        public static List<Mitarbeiter> MitarbeiterListe = new List<Mitarbeiter>();

        //Instanzvariable
        private string nachname;
        private string vorname;
        private string abteilung;
        private string geschlecht;
        private List<Betriebsmittel> arbeitsmittel;
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

        public void SetArbeitsmittel(List<Betriebsmittel> arbeitsmittel)
        {
            this.arbeitsmittel = arbeitsmittel;
        }
        public List<Betriebsmittel> GetArbeitsmittel()
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
