using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PryTaquilla.Boleto
{
    public partial class FrmBoleto : Form
    {
        public FrmBoleto()
        {
            InitializeComponent();
        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            Boleto miBoleto = null;
            int cantidadBoletos = (int)numCantidad.Value;
            float costoBase = 50.00f;
            string categoriaSeleccionada = cbCategoria.SelectedItem.ToString();



            if (categoriaSeleccionada == "Estudiante")
            {
               
            }
            else if (categoriaSeleccionada == "Adulto Mayor")
            {
                
            }
            else if (categoriaSeleccionada == "General")
            {
                
            }

            
            if (miBoleto != null)
            {
                float totalAPagar = miBoleto.CalcularPrecioFinal();
                MessageBox.Show("Total a pagar: $" + totalAPagar.ToString("0.00"), "Compra Exitosa");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría válida antes de comprar.", "Atención");
            }
        }
    }
}
