using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Aplicacion1.Clases
{
    public class Clientes : INotifyPropertyChanged 
    {
        private String nombre;
        public String Nombre { 
            get { return nombre; }
            set 
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            } 
        }
        public String Apellidos { get; set; }

        public Clientes (String nombre, String apellidos)
        {
            this.nombre = nombre;
            this.Apellidos = apellidos;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Nombre + " " + Apellidos;
        }
    }
}
