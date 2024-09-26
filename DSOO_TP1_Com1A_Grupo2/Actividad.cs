using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1_Com1A_Grupo2
{
    internal class Actividad
    {
        private string nombre;
        private int costo;
        private int capacidad;
        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string getNombre()
        {
            return nombre;
        }
        public Actividad(string nombre, int costo, int capacidad)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.capacidad = capacidad;
        }
    }
}
