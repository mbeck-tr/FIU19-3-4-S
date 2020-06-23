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

namespace WPF_Layout
{
    /// <summary>
    /// Interaktionslogik für viewBoxLayout.xaml
    /// </summary>
    public partial class viewBoxLayout : Window
    {
        public viewBoxLayout()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            viewbox1.Stretch = Stretch.Fill;
        }

        private void btnUniformToFill_Click(object sender, RoutedEventArgs e)
        {
            viewbox1.Stretch = Stretch.UniformToFill;
        }

        private void btnUniform_Click(object sender, RoutedEventArgs e)
        {
            viewbox1.Stretch = Stretch.Uniform;
        }

        private void btnNone_Click(object sender, RoutedEventArgs e)
        {
            viewbox1.Stretch = Stretch.None;
        }
    }
}
