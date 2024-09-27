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
            cargarActividades();
        }
        public void cargarActividades()
        {
            agregarActividad("Natacion", 100, 10);
            agregarActividad("Voley", 150, 15);
            agregarActividad("Futbol", 200, 20);
            agregarActividad("Basquet", 250, 25);
            agregarActividad("Handball", 300, 30);
            agregarActividad("Rugby", 350, 35);
            agregarActividad("Tenis", 400, 40);
            agregarActividad("Golf", 450, 45);
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
