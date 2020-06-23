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
using System.Diagnostics;

namespace WPF_Layout
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

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout StackPanel Container öffnen");
            StackpanelLayout stackpanelLayout = new StackpanelLayout();
            stackpanelLayout.ShowDialog();
            Debug.WriteLine("Layout StackPanel Container geschlossen");
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout Canvas Container öffnen");
            CanvasLayout canvasLayout = new CanvasLayout();
            canvasLayout.ShowDialog();
            Debug.WriteLine("Layout Canvas Container geschlossen");
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout WrapPanel Container öffnen");
            wrapPanelLayout wrappanellayout = new wrapPanelLayout();
            wrappanellayout.ShowDialog();
            Debug.WriteLine("Layout WrapPanel Container geschlossen");
        }

        private void btnUniformGrid_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout UniformGrid Container öffnen");
            uniformGridLayout uniformGridLayout = new uniformGridLayout();
            uniformGridLayout.ShowDialog();
            Debug.WriteLine("Layout UniformGrid Container geschlossen");
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout Grid Container öffnen");

            gridLayout gridLayout = new gridLayout();
            gridLayout.ShowDialog();

            Debug.WriteLine("Layout Grid Container geschlossen");
        }

        private void btnViewBox_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout Viewbox Container öffnen");
            viewBoxLayout viewBoxLayout = new viewBoxLayout();
            viewBoxLayout.ShowDialog();
            Debug.WriteLine("Layout Viewbox Container geschlossen");
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Layout Dockpanel Container öffnen");
            dockPanelLayout dockPanelLayout = new dockPanelLayout();
            dockPanelLayout.ShowDialog();
            Debug.WriteLine("Layout Dockpanel Container geschlossen");
        }
    }
}
