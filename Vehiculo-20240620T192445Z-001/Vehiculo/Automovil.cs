using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    internal class Automovil : Vehiculo
    {
        public string matricula;
        private int cantidadpuertas;
        private String tipocombustible;

        public int Cantidadpuertas
        {
            get => cantidadpuertas;
            set => cantidadpuertas = value;
        }
        public String Tipocompustible
        {
            get => tipocombustible;
            set => tipocombustible = value;
        }
        public String Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public override String MostrarInformacion()
        {
            
            return base.MostrarInformacion() + "Cantidad de puertas: " + this.cantidadpuertas +
            "Año " + this.Año;
        }

    }
}

