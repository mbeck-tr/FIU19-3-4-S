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

namespace WPF_Controls
{
    /// <summary>
    /// Interaktionslogik für Steuerelemente.xaml
    /// </summary>
    public partial class Steuerelemente : Window
    {
        public Steuerelemente()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("btn1 geklickt");
        }

        private void rbtn1_Click(object sender, RoutedEventArgs e)
        {
            /*
            Click               event event event event
            ___|-|______________|-|___|-|___|-|___|-|___|-|___|-|___|-|___|-|___
            Start <--- Delay --->   -->      <--- Intervall (500 ms)
                    (2000 ms)
             */
            Debug.WriteLine("repeat button event raised");
        }

        private void tbtn1_Checked(object sender, RoutedEventArgs e)
        {
            printToggleButtonState();
        }

        private void tbtn1_Unchecked(object sender, RoutedEventArgs e)
        {
            printToggleButtonState();
        }

        private void printToggleButtonState()
        {
            Debug.WriteLine("Togglebutton checked: " + tbtn1.IsChecked);
        }

        private void btnContent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCursor_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Cursorposiiton: " + txtbMultiline.CaretIndex);
            txtbMultiline.CaretIndex = 5;
            
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            var pos = txtbMultiline.CaretIndex;
            var ersterTeil = txtbMultiline.Text.Substring(0, pos);
            var zweiterTeil = txtbMultiline.Text.Substring(pos);
            txtbMultiline.Text = ersterTeil + " Text " + zweiterTeil;
        }

        private void txtb2_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("Password: " + txtb2.Password);
            if (txtb2.Password == "geheim")
                MessageBox.Show("Tresor öffnet sich");
        }

        private void cb1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb1_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb1.SelectedItems.Count > 1)
            {
                Debug.WriteLine("Listbox Mehrfachauswahl\n---------------------");
                foreach (var item in lb1.SelectedItems)
                {
                    Debug.WriteLine("Listboxelement: " + item.ToString());
                }
            }
            else
            {
                Debug.WriteLine("Listbox Einfachauswahl\n----------------------");
                Debug.WriteLine("Listbox Auswahl: " + lb1.SelectedItem.ToString());
            }
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("gewähltes Element: " + combo1.SelectedItem + 
                                Environment.NewLine +
                            "gewählter Index: " + (combo1.SelectedIndex != -1 ? combo1.SelectedIndex.ToString() : "kein Index"));
        }
    }
}
