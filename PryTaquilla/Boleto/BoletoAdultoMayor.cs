using System;
using System.Collections.Generic;
using System.Text;

namespace PryTaquilla.Boleto
{
    internal class BoletoAdultoMayor : Boleto
    {
        public int Edad 
        {
            get; set; 
        }

        public BoletoAdultoMayor(string _nombre, int _cantidad, float _precio, int _edad)

            : base(_nombre, _cantidad, _precio)
        {
            Edad = _edad;
        }

        public override float CalcularPrecioFinal()
        {
            return (precio * cantidad) * 0.50f;
        }
    }
}
