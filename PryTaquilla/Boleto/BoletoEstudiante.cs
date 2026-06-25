using System;
using System.Collections.Generic;
using System.Text;

namespace PryTaquilla.Boleto
{
    internal class BoletoEstudiante : Boleto
    {
        
        public string Matricula { get; set; }
        public BoletoEstudiante(string _nombre, int _cantidad, float _precio, string _matricula): base(_nombre, _cantidad, _precio)
        {
            Matricula = _matricula;
        }
        public override float CalcularPrecioFinal()
        {
            float descuento;
            descuento = Precio * 30 / 100;
            return Cantidad * (precio - descuento);
        }

    }
}
