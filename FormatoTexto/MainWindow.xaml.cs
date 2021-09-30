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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.FontStyle = FontStyles.Italic;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.Foreground = Brushes.Blue;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.Foreground = Brushes.Red;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.Foreground = Brushes.Green;
        }

        private void TextoEntranteTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoSalienteTextBlock.Text=TextoEntranteTextBox.Text;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoSalienteTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
