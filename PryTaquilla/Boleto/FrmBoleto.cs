using Microsoft.VisualBasic.Logging;
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
                miBoleto = new BoletoEstudiante("", cantidadBoletos, costoBase, "");

            }
            else if (categoriaSeleccionada == "Adulto Mayor")
            {

                string nombreCliente = "Cliente Prueba";
                int edadCliente = 70; 

                if (edadCliente >= 65)
                {
                    miBoleto = new BoletoAdultoMayor(nombreCliente, cantidadBoletos, costoBase, edadCliente);
                }
                else
                {
                    MessageBox.Show("El cliente debe tener 65 años o más para aplicar a esta categoría.", "Edad no válida");
                }
            }
            else if (categoriaSeleccionada == "General")
            {
                miBoleto = new BoletoGeneral(" Boleto General ", cantidadBoletos, costoBase);
            }


            if (miBoleto != null)
            {
                float totalAPagar = miBoleto.CalcularPrecioFinal();

                string resumenCompra = $"Categoría seleccionada: {categoriaSeleccionada}\r\n" +
                                       $"Cantidad de boletos: {miBoleto.cantidad}\r\n" +
                                       $"Costo base: ${miBoleto.precio}\r\n" +

                                       $"---------------------------\r\n" +
                                       $"Total a pagar: ${totalAPagar.ToString("0.00")}";

                MessageBox.Show(resumenCompra, "Ticket de Compra");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría válida antes de calcular.", "Atención");
            }
        }
    }
}
