using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace Aplicacion1.Clases
{
    public class Juguetes : INotifyPropertyChanged 
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
        public String Edad
        {
            get { return edad; }
            set
            {
                this.edad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Edad"));
            }
        }
        public String Tipo
        {
            get { return tipo; }
            set
            {
                this.tipo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("tipo"));

                
            }
        }
        public Boolean Stock
        {
            get { return stock; }
            set
            {
                this.stock = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("stock"));
            }
        }
        public String Codigo
        {
            get { return codigo; }
            set
            {
                this.codigo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("codigo"));
            }
        }



        public String edad { get; set; }

        public  Boolean stock { get; set; }
        public String tipo { get; set; }
        public String codigo { get; set; }
        public TextBox Txt_nombre { get; }
        public TextBox Txt_tipo { get; }
        
        public TextBox Txt_edad { get; }
        public TextBox Txt_codigo { get; }

        public Juguetes (String nombre, String tipo, Boolean stock, String edad, String codigo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.stock = stock;
            this.edad = edad;
            this.codigo = codigo;


        }


        public Juguetes(TextBox txt_nombre, TextBox txt_tipo, TextBox txt_stock, TextBox txt_edad, TextBox txt_codigo)
        {
            
            Txt_nombre = txt_nombre;
            Txt_tipo = txt_tipo;
            
            Txt_edad = txt_edad;
            Txt_codigo = txt_codigo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Nombre + " " + Stock+ " "+ Edad+ " "+ Codigo+" "+tipo;
        }
    }
}
