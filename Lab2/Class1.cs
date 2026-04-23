using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Solicitante
    {
        //Atributos
        private string nombre, ID;
        private int plazo;
        private double salarioMensual, montoPrestamo, tasa, porcMax;

        //Método Constructor
        public Solicitante(string nombre, string ID, int plazo, double salarioMensual, double montoPrestamo, double tasa, double porcMax)
        {
            this.nombre = nombre;
            this.ID = ID;
            this.plazo = plazo;
            this.salarioMensual = salarioMensual;
            this.montoPrestamo = montoPrestamo;
            this.tasa = tasa;
            this.porcMax = porcMax;
        }

        //Método set
        public void setNombre(string nombre)
        {

        }

        //Método get
        public string getNombre()
        {
            return nombre;
        }
        public string getId()
        {
            return ID;
        }
        public int getPlazo()
        {
            return plazo;
        }
        public double getSalarioMensual()
        {
            return salarioMensual;
        }
        public double getMontoPrestamo()
        {
            return montoPrestamo;
        }
        public double getTasa()
        {
            return tasa;
        }
        public double getPorcMax()
        {
            return porcMax;
        }

        //Funciones
        public double CalcularCuota()
        {
            double cuota = 0;
            if (salarioMensual > 0)
            {
                cuota = montoPrestamo * ((tasa * Math.Pow(1 + tasa, plazo)) / (Math.Pow(1 + tasa, plazo) - 1));
            }
            return cuota;
        }

        public int Aprobado(double cuota)
        {
            int aprobado = 0;
            if (cuota <= salarioMensual * porcMax && cuota > 0)
            {
                if (salarioMensual > 0)
                {
                    aprobado = 1;
                }
            }
            else if(cuota > salarioMensual * porcMax && cuota <= salarioMensual * (porcMax + 0.1))
            {
                aprobado = 2;
            }
            else if (cuota > salarioMensual * (porcMax + 0.1))
            {
                aprobado = 3;
            }
            return aprobado;
        }


    }
}
