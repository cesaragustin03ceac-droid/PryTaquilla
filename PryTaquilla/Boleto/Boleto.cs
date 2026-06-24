using System;
using System.Collections.Generic;
using System.Text;

namespace PryTaquilla.Boleto
{
    internal abstract class Boleto
    {

        //atributo
        protected string Nombre;
        protected float Precio;
        protected int Cantidad;


        //propiedad
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public float precio
        {
            get { return Precio; }
            set
            {
                if (value > 0)
                    Precio = value;
            }
        }

        public int cantidad
        {
            get { return Cantidad; }
            set
            {
                if (value > 0)
                    Cantidad = value;
            }
        }



        //constructor parametrizado
        public Boleto(string _nombre, int _cantidad, float _precio)
        {
            Nombre = _nombre;
            Cantidad = _cantidad;
            Precio = _precio;
        }

        // contructor vacio
        public Boleto()
        {
            Nombre = "";
            cantidad = 0;
            Precio = 0.0F;
        }

        public abstract float CalcularPrecioFinal();
    }
}
