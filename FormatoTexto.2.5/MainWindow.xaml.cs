﻿using System;
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

namespace FormatoTexto._2._5
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
        //Texto
        private void TextoAFormatearTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoFormateadoTextBlock.Text = TextoAFormatearTextBox.Text;
        }

        //Estilos
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.FontStyle = FontStyles.Normal;
        }

        //Colores

        private void ColorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.Foreground = Brushes.Blue;
        }

        private void ColorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.Foreground = Brushes.Red;
        }

        private void ColorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoFormateadoTextBlock.Foreground = Brushes.Green;
        }

        
    }
}
