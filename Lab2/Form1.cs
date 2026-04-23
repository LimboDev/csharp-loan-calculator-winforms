using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VerificarCampos()
        {
            if (tbNombre.Text != "" && tbID.Text != "" && tbSalario.Text != "" && tbPrestamo.Text != "" && cbPlazo.Text != "")
            {
                    btEvaluar.Enabled = true;
            }
            else
            {
                btEvaluar.Enabled = false;
            }
        }
        private void btEvaluar_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string nombre, ID;
            int plazo;
            double salarioMensual, montoPrestamo, tasa, porcMax;

            nombre = tbNombre.Text;
            ID = tbID.Text;
            plazo = 0; //En caso de error
            tasa = 0; //En caso de error
            porcMax = 0; //En caso de error
            if (cbPlazo.Text == "12 meses")
            {
                plazo = 12;
            }
            else if (cbPlazo.Text == "24 meses")
            {
                plazo = 24;
            }
            else if (cbPlazo.Text == "36 meses")
            {
                plazo = 36;
            }
            salarioMensual = Convert.ToDouble(tbSalario.Text);
            montoPrestamo = Convert.ToDouble(tbPrestamo.Text);
            if (plazo == 12)
            {
                tasa = 0.015;
            }
            if (plazo == 24)
            {
                tasa = 0.018;
            }
            if (plazo == 36)
            {
                tasa = 0.021;
            }
            if (plazo == 12)
            {
                porcMax = 0.3;
            }
            if (plazo == 24)
            {
                porcMax = 0.4;
            }
            if (plazo == 36)
            {
                porcMax = 0.5;
            }
            //Creación del objeto Solicitante
            Solicitante solicitante = new Solicitante(nombre, ID, plazo, salarioMensual, montoPrestamo, tasa, porcMax);
            //Calcular datos
            double cuota = solicitante.CalcularCuota();
            int aprobado = solicitante.Aprobado(cuota);
            lbDatos.Text = "Solicitante: " + nombre + ", ID: " + ID;
            if (aprobado == 1 && cuota > 0)
            {
                lbEvaluado.Text = "Su préstamo fue aprobado.";
            }
            else if (aprobado == 2 && cuota > 0)
            {
                lbEvaluado.Text = "Su préstamo fue aprobado \n" +
                    "a medias, necesita aval.";
            }
            else if (aprobado == 3 && cuota > 0)
            {
                lbEvaluado.Text = "Su préstamo fue rechazado.";
            }
            else
            {
                lbEvaluado.Text = "Error: No se admiten valores negativos";
            }
            if (aprobado == 1 || aprobado == 2)
            {
                lbCuota.Text = "Su cuota mensual es de: $" + cuota.ToString("F2");
            }
            if (aprobado == 1 || aprobado == 2)
            {
                double porcSalario = ((cuota * 100) / salarioMensual);
                lbPorcentaje.Text = "La cuota representa el " + porcSalario.ToString("F2") + "% de su salario mensual.";
            }
            else
            {
                lbCuota.Text = "";
                lbPorcentaje.Text = "";
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbSalario_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbPrestamo_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void cbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }
    }
}
