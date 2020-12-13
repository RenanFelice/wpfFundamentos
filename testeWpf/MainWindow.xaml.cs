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

namespace testeWpf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Botao1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"A descrição é: {this.linkBotao1.Text}");
        }

        private void ResetInputs_Click(object sender, RoutedEventArgs e)
        {
            this.checkbox1.IsChecked = this.checkbox2.IsChecked = this.checkbox3.IsChecked = this.checkbox4.IsChecked =
            this.checkbox5.IsChecked = this.checkbox6.IsChecked = this.checkbox7.IsChecked = this.checkbox8.IsChecked = false;
            this.checkboxSelection.Text = "";
            this.dropdownSelection.Text = "";
            this.linkBotao1.Text = "";
            this.mimicText.Text = "";
            this.mimicTextInput.Text = "";
        }

    
        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            string temp = (string)((CheckBox)sender).Content;
            if (this.checkboxSelection.Text.Contains(temp)) return;
            this.checkboxSelection.Text += $"{((CheckBox)sender).Content}; ";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var comboItem = (ComboBoxItem)combo.SelectedValue;

            this.dropdownSelection.Text = (string)comboItem.Content;
        }

        private void MimicTextInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            this.mimicText.Text = this.mimicTextInput.Text;
        }
    }
}
