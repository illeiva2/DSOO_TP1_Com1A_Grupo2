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
        public Cliente? buscarCliente(string dni, bool nuevo)
        {
            if (!nuevo)
            {
                foreach (Cliente cliente in clientes)
                {
                    if (cliente.Dni == dni)
                    {
                        return cliente;
                    }
                }
                Console.WriteLine("SOCIO INEXISTENTE");
                return null;
            }
            return null;
        }
        public bool altaSocio(string nombre, string apellido, string email, string dni, string telefono, bool nuevo)
        {
            if (buscarCliente(nombre, nuevo) == null)
            {
                id++;
                clientes.Add(new Cliente(id, nombre, apellido, email, dni, telefono));
                return true;
            }
            return false;
        }
        public bool eliminarCliente(string dni)
        {
            Cliente? cliente = buscarCliente(dni, false);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                return true;
            }
            return false;
        }
        public void listarClientes()
        {
            Console.WriteLine("\n\nLista de clientes:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("\t\t\tNombre: " + cliente.Nombre + " Apellido: " + cliente.Apellido);
            }
        }
    }
}
