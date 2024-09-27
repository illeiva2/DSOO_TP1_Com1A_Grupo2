using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1_Com1A_Grupo2
{
    internal class Actividades
    {
        public List<Actividad> actividades;
        public Actividades()
        {
            actividades = new List<Actividad>();
        }
        public Actividad? buscarActividad(string nombre)
        {
            foreach (Actividad actividad in actividades)
            {
                if (actividad.getNombre() == nombre)
                {
                    return actividad;
                }
            }
            return null;
        }
        public bool agregarActividad(string nombre, int costo, int capacidad)
        {
            if (buscarActividad(nombre) == null)
            {
                actividades.Add(new Actividad(nombre, costo, capacidad));
                return true;
            }
            return false;
        }
        //public bool eliminarActividad(string nombre)
        //{
        //    Actividad? actividad = buscarActividad(nombre);
        //    if (actividad != null)
        //    {
        //        actividades.Remove(actividad);
        //        return true;
        //    }
        //    return false;
        //}
        public void listarActividades()
        {
            foreach (Actividad actividad in actividades)
            {
                Console.WriteLine("Nombre: " + actividad.getNombre() );
            }
        }
    }
}
