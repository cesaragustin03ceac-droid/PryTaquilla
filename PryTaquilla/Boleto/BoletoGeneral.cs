using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PryTaquilla.Boleto
{
    internal class BoletoGeneral : Boleto
    {
        public BoletoGeneral(string nombre,int cantidad,float precio) : base(nombre, cantidad, precio)
        {

        }
        public override float CalcularPrecioFinal()
        {
            return Cantidad * Precio;
        }
    }
}