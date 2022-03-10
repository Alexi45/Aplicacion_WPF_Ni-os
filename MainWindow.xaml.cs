using Aplicacion1.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Aplicacion1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection <Juguetes> listaJuguete { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listaJuguete = new ObservableCollection<Juguetes>();
            listaJuguete.Add(new Juguetes("Batman", "DC", true, "34", "32"));
            listaJuguete.Add(new Juguetes("Iron man", "Marv", true, "15", "3"));
            listaJuguete.Add(new Juguetes("Superman", "DC", true, "6", "2"));
            listaJuguete.Add(new Juguetes("Ant-Man", "Marv", true, "145", "7"));
            listaJuguete.Add(new Juguetes("Spider-Man", "Marv", true, "15", "3"));
            listaJuguete.Add(new Juguetes("Thor", "Marv", true, "135", "1"));
            this.DataContext = this;
        }



        private void botonir(object sender, RoutedEventArgs e)
        {
            Ventanados I = new Ventanados();
            I.Show();
            this.Close();
        }




        public void modificarNombre(object sender, RoutedEventArgs e)
        {

            listaJuguete.ElementAt(0).Nombre = txt_nombre.Text;
            listaJuguete.ElementAt(1).Nombre = txt_nombre.Text;
            listaJuguete.ElementAt(2).Nombre = txt_nombre.Text;
            listaJuguete.ElementAt(3).Nombre = txt_nombre.Text;
            listaJuguete.ElementAt(4).Nombre = txt_nombre.Text;
            listaJuguete.ElementAt(5).Nombre = txt_nombre.Text;

        }
        public void modificarTipo(object sender, RoutedEventArgs e)
        {

            listaJuguete.ElementAt(0).Tipo = txt_tipo.Text;
            listaJuguete.ElementAt(1).Tipo = txt_tipo.Text;
            listaJuguete.ElementAt(2).Tipo = txt_tipo.Text;
            listaJuguete.ElementAt(3).Tipo = txt_tipo.Text;
            listaJuguete.ElementAt(4).Tipo = txt_tipo.Text;
            listaJuguete.ElementAt(5).Tipo = txt_tipo.Text;

        }
        public void modificarCodigo(object sender, RoutedEventArgs e)
        {

            listaJuguete.ElementAt(0).Codigo = txt_codigo.Text;
            listaJuguete.ElementAt(1).Codigo = txt_codigo.Text;
            listaJuguete.ElementAt(2).Codigo = txt_codigo.Text;
            listaJuguete.ElementAt(3).Codigo = txt_codigo.Text;
            listaJuguete.ElementAt(4).Codigo = txt_codigo.Text;
            listaJuguete.ElementAt(5).Codigo = txt_codigo.Text;

        }
        public void modificaredad(object sender, RoutedEventArgs e)
        {

            listaJuguete.ElementAt(0).Edad = txt_edad.Text;
            listaJuguete.ElementAt(1).Edad = txt_edad.Text;
            listaJuguete.ElementAt(2).Edad = txt_edad.Text;
            listaJuguete.ElementAt(3).Edad = txt_edad.Text;
            listaJuguete.ElementAt(4).Edad = txt_edad.Text;
            listaJuguete.ElementAt(5).Edad = txt_edad.Text;

        }
        public void modificarStock(object sender, RoutedEventArgs e)
        {
            listaJuguete.ElementAt(0).Stock = false;
            listaJuguete.ElementAt(1).Stock = false;
            listaJuguete.ElementAt(2).Stock = false;
            listaJuguete.ElementAt(3).Stock = false;
            listaJuguete.ElementAt(4).Stock = false;

            listaJuguete.ElementAt(5).Stock = false;
        }

    }
}
