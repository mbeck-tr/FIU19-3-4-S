using System;
using System.Windows;

// Verweise:
// System.Windows
// System.Presentation.Framework
// WindowsBase

namespace ErsteWPFAnwendung
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Nun kommt ein WPF Fenster:");
            
            Window einFenster = new Window();
            einFenster.Title = "Erstes WPF-Fenster";
            Application app = new Application();
            app.Run(einFenster);

            Console.WriteLine("Fenster geschlossen");
            Console.ReadKey();
        }
    }
}
