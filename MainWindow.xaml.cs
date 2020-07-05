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

namespace Wpf01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"the description is {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.AssemblyCheckBox.IsChecked = this.WeldCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked
                = this.RollCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.LatheCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked
                = this.DrillWeldCheckBox.IsChecked = this.SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LenghtText.Text += ((CheckBox)sender).Content;
        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;


            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteText.Text = (string)value.Content;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.FinishComboBox_SelectionChanged(this.FinishComboBox, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = ((TextBox)sender).Text;
        }
    }
}
