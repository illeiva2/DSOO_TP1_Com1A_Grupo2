using System.Security.Cryptography.X509Certificates;

namespace DSOO_TP1_Com1A_Grupo2
{
    internal class ClubDeportivo
    {
        public static Actividades listaActividades = new();
        static void Main(string[] args)
        {
            listaActividades.agregarActividad("Natacion", 100, 10);
            listaActividades.agregarActividad("Voley", 150, 15);
            listaActividades.agregarActividad("Futbol", 200, 20);
            listaActividades.agregarActividad("Basquet", 250, 25);
            listaActividades.agregarActividad("Handball", 300, 30);
            listaActividades.agregarActividad("Rugby", 350, 35);
            listaActividades.agregarActividad("Tenis", 400, 40);
            listaActividades.agregarActividad("Golf", 450, 45);
            Clientes clientes = new();
            int opcion = 0;
            while (opcion != 7)
            {
                Console.WriteLine("Bienvenido al Club Deportivo");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Eliminar Cliente");
                Console.WriteLine("3. Listar Clientes");
                Console.WriteLine("4. Inscribir cliente a una actividad");
                Console.WriteLine("5. Listar actividades de un cliente");
                Console.WriteLine("7. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del cliente");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del cliente");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el email del cliente");
                        string email = Console.ReadLine();
                        Console.WriteLine("Ingrese el DNI del cliente");
                        string dni = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono del cliente");
                        string telefono = Console.ReadLine();
                        if (clientes.altaSocio(nombre, apellido, email, dni, telefono))
                        {
                            Console.WriteLine("Cliente agregado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("El cliente ya existe");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el DNI del cliente a eliminar");
                        dni = Console.ReadLine();
                        if (clientes.eliminarCliente(dni))
                        {
                            Console.WriteLine("Cliente eliminado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("El cliente no existe");
                        }
                        break;
                    case 3:
                        clientes.listarClientes();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el nombre del cliente");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre de la actividad");
                        string actividad = Console.ReadLine();
                        clientes.inscribirClienteActividad(nombre, actividad);
                        break;
                        case 5:
                        Console.WriteLine("Ingrese el nombre del cliente");
                        nombre = Console.ReadLine();
                        Cliente? cliente = clientes.buscarCliente(nombre);
                        cliente.listarActividades();
                        break;
                    case 7:
                        break;
                }
            
            }
        }
    }
}
