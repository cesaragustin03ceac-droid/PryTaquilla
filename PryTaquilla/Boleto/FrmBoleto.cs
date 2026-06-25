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
            string categoriaSeleccionada = cbTipo.SelectedItem.ToString();

            if (cantidadBoletos <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (categoriaSeleccionada == "Estudiante")
            {
                miBoleto = new BoletoEstudiante("", cantidadBoletos, costoBase, "");

            }
            else if (categoriaSeleccionada == "Adulto Mayor")
            {
                miBoleto = new BoletoEstudiante("", cantidadBoletos, costoBase, "");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBoleto_Load(object sender, EventArgs e)
        {

            cbCategoria.Items.Clear();

            cbCategoria.Items.Add("Terror");
            cbCategoria.Items.Add("Suspenso");
            cbCategoria.Items.Add("Acción");
            cbCategoria.Items.Add("Comedia");
            cbCategoria.Items.Add("Infantil");

            cbCategoria.SelectedIndex = 0;



            cbTipo.Items.Clear();

            cbTipo.Items.Add("Estudiante");
            cbTipo.Items.Add("Adulto Mayor");
            cbTipo.Items.Add("General");

            cbTipo.SelectedIndex = 0;
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cbTipo.SelectedItem?.ToString();

            if (categoriaSeleccionada == "Estudiante")
            {
                txtMatricula.Enabled = true;

                txtINAPAM.Enabled = false;
                txtINAPAM.Clear();
            }
            else if (categoriaSeleccionada == "Adulto Mayor")
            {
                txtMatricula.Enabled = false;
                txtMatricula.Clear();

                txtINAPAM.Enabled = true;
            }
            else if (categoriaSeleccionada == "General")
            {
                txtMatricula.Enabled = false;
                txtMatricula.Clear();

                txtINAPAM.Enabled = false;
                txtINAPAM.Clear();
            }
        }
    }
}
