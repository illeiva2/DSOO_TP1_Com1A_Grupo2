using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_TP1_Com1A_Grupo2
{
    internal class Cliente
    {
        private int id;
        private string? nombre;
        private string? apellido;
        private string? email;
        private string? dni;
        private string? telefono;
        public List<Actividad> actividades;
        public Cliente(int id, string nombre, string apellido, string email, string dni, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.dni = dni;
            this.telefono = telefono;
            actividades = new List<Actividad>();
        }
        public int getId() { return id; }
        public void inscribirActividad(Actividad actividad)
        {
            actividades.Add(actividad);
        }
        public void listarActividades()
        {
            Console.WriteLine("Actividades de " + nombre + " " + apellido + ": \n");
            foreach (Actividad actividad in actividades)
            {
                Console.WriteLine("\tNombre: " + actividad.getNombre());
            }
        }
        public string? Nombre { get { return nombre; } set { nombre = value; } }
        public string? Apellido { get { return apellido; } set { apellido = value; } }
        public string? Email { get { return email; } set { email = value; } }
        public string? Dni { get { return dni; } set { dni = value; } }
        public string? Telefono { get { return telefono; } set { telefono = value; } }
    }
}
