using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DSOO_TP1_Com1A_Grupo2
{
    internal class Clientes
    {
        private List<Cliente> clientes;
        private int id;
        public Clientes()
        {
            clientes = new List<Cliente>();
        }
        public Cliente? buscarCliente(string dni)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Dni == dni)
                {
                    return cliente;
                }
            }
            Console.WriteLine("No se encontro el cliente");
            return null;
        }
        public bool altaSocio(string nombre, string apellido, string email, string dni, string telefono)
        {
            if (buscarCliente(nombre) == null)
            {
                id++;
                clientes.Add(new Cliente(id, nombre, apellido, email, dni, telefono));
                return true;
            }
            return false;
        }
        public bool eliminarCliente(string dni)
        {
            Cliente? cliente = buscarCliente(dni);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                return true;
            }
            return false;
        }
        public void listarClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nombre: " + cliente.Nombre + " Apellido: " + cliente.Apellido);
            }
        }
        public void inscribirClienteActividad(string dni, string actividad)
        {
            Cliente? cliente = buscarCliente(dni);
            if (cliente != null)
            {
                Actividad? act = ClubDeportivo.listaActividades.buscarActividad(actividad);
                if (act != null)
                {
                    if (cliente.actividades.Count == 0)
                    {
                        act.Capacidad--;
                        cliente.inscribirActividad(act);
                        Console.WriteLine("INSCRIPCION EXITOSA");
                        return;
                    }
                    else if (cliente.actividades.Count >= 3)
                    {
                        Console.WriteLine("TOPE DE ACTIVIDADES ALCANZADO");
                        return;
                    }
                    else
                    {
                        foreach (Actividad activida in cliente.actividades)
                        {
                            if (activida.getNombre() == actividad)
                            {
                                Console.WriteLine("EL CLIENTE YA ESTA INSCRIPTO EN ESTA ACTIVIDAD");
                                return;
                            }
                        }
                        act.Capacidad--;
                        cliente.inscribirActividad(act);
                        Console.WriteLine("INSCRIPCION EXITOSA");
                        return;
                    }
                }
                Console.WriteLine("ACTIVIDAD INEXISTENTE");
                return;
            }
            Console.WriteLine("SOCIO INEXISTENTE");
            return;
        }
    }
}
