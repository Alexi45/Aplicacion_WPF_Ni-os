using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplicacion1
{
    /// <summary>
    /// Lógica de interacción para Ventanados.xaml
    /// </summary>
    public partial class Ventanados : Window
    {
        public Ventanados()
        {
            InitializeComponent();
            


        }
        private void botonir(object sender, RoutedEventArgs e)
        {
            MainWindow I = new MainWindow();
            I.Show();
            this.Close();
        }
    }
}
