using System;
using System.Windows;
using System.Windows.Controls;

namespace Actividad4_LimitacionCaracteres
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

        private void escribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int longitud = escribirTextBox.Text.Length;
            if (longitud == 140)
                escribirTextBox.IsReadOnly = true;
        }
    }
}
