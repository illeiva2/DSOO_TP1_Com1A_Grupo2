namespace DSOO_TP1_Com1A_Grupo2
{
    internal class ClubDeportivo
    {
        static void Main(string[] args)
        {
            Actividades actividades = new();
            Clientes clientes = new();
            int opcion = 0;
            while (opcion != 6)
            {
                Console.WriteLine("Bienvenido al Club Deportivo");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Eliminar Cliente");
                Console.WriteLine("3. Listar Clientes");
                Console.WriteLine("4. Inscribir cliente a una actividad");
                Console.WriteLine("5. Listar actividades de un cliente");
                Console.WriteLine("6. Salir");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    opcion = 0;
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los datos del cliente:");

                        Console.Write("Nombre: ");
                        string? nombre = Console.ReadLine();
                        while (string.IsNullOrEmpty(nombre))
                        {
                            Console.WriteLine("El nombre no puede estar vacío.");
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine();
                        }
                        Console.Write("Apellido: ");
                        string? apellido = Console.ReadLine();
                        while (string.IsNullOrEmpty(apellido))
                        {
                            Console.WriteLine("El apellido no puede estar vacío.");
                            Console.Write("Apellido: ");
                            apellido = Console.ReadLine();
                        }
                        Console.Write("Email: ");
                        string? email = Console.ReadLine();
                        while (string.IsNullOrEmpty(email))
                        {
                            Console.WriteLine("El email no puede estar vacío.");
                            Console.Write("Email: ");
                            email = Console.ReadLine();
                        }
                        Console.Write("DNI: ");
                        string? dni = Console.ReadLine();
                        while (string.IsNullOrEmpty(dni))
                        {
                            Console.WriteLine("El dni no puede estar vacío.");
                            Console.Write("Dni: ");
                            dni = Console.ReadLine();
                        }
                        Console.Write("Teléfono: ");
                        string? telefono = Console.ReadLine();
                        while (string.IsNullOrEmpty(telefono))
                        {
                            Console.WriteLine("El telefono no puede estar vacío.");
                            Console.Write("Telefono: ");
                            telefono = Console.ReadLine();
                        }
                        Console.Clear();
                        if (clientes.altaSocio(nombre, apellido, email, dni, telefono, true))
                        {
                            imprimirMensaje("\n\nCliente agregado correctamente");
                        }
                        else
                        {
                            imprimirMensaje("El cliente ya existe");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el DNI del cliente a eliminar");
                        dni = Console.ReadLine();
                        while (string.IsNullOrEmpty(dni))
                        {
                            Console.WriteLine("El dni no puede estar vacío.");
                            Console.Write("Dni: ");
                            dni = Console.ReadLine();
                        }
                        if (clientes.eliminarCliente(dni))
                        {
                            imprimirMensaje("Cliente eliminado correctamente");
                        }
                        else
                        {
                            imprimirMensaje("El cliente no existe");
                        }
                        break;
                    case 3:
                        clientes.listarClientes();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Ingrese el dni del cliente: ");
                        dni = Console.ReadLine();
                        while (string.IsNullOrEmpty(dni))
                        {
                            Console.WriteLine("El dni no puede estar vacío.");
                            Console.Write("Dni: ");
                            dni = Console.ReadLine();
                        }
                        Console.Write("Ingrese el nombre de la actividad: ");
                        string? actividad = Console.ReadLine();
                        while (string.IsNullOrEmpty(actividad))
                        {
                            Console.WriteLine("Por favor ingrese un valor.");
                            Console.Write("Ingrese el nombre de la actividad: ");
                            actividad = Console.ReadLine();
                        }
                        inscribirActividad(dni, actividad);
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el dni del cliente");
                        dni = Console.ReadLine();
                        while (string.IsNullOrEmpty(dni))
                        {
                            Console.WriteLine("Por favor ingrese un valor.");
                            Console.Write("Ingrese el nombre del cliente: ");
                            dni = Console.ReadLine();
                        }
                        Cliente? cliente = clientes.buscarCliente(dni, false);
                        if (cliente != null)
                        {
                            cliente.listarActividades();
                        }
                        break;
                    case 6:
                        break;
                    default:
                        {
                            imprimirMensaje("Ingrese un numero válido");
                            break;
                        }
                }
            }
            void imprimirMensaje(string mensaje)
            {
                Console.WriteLine(mensaje);
                Thread.Sleep(2000);
                Console.Clear();
            }
            void inscribirActividad(string dni, string actividad)
            {
                Cliente? cliente = clientes.buscarCliente(dni, false);
                if (cliente != null)
                {
                    Actividad? act = actividades.buscarActividad(actividad);
                    if (act != null)
                    {
                        if (cliente.actividades.Count == 0)
                        {
                            act.Capacidad--;
                            cliente.inscribirActividad(act);
                            imprimirMensaje("INSCRIPCION EXITOSA");
                            return;
                        }
                        else if (act.Capacidad == 0)
                        {
                            Console.WriteLine("NO HAY CAPACIDAD EN LA ACTIVIDAD " + act.getNombre());
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                        else if (cliente.actividades.Count >= 3)
                        {
                            imprimirMensaje("TOPE DE ACTIVIDADES ALCANZADO");
                            return;
                        }
                        else
                        {
                            foreach (Actividad activida in cliente.actividades)
                            {
                                if (activida.getNombre() == actividad)
                                {
                                    imprimirMensaje("EL CLIENTE YA ESTA INSCRIPTO EN ESTA ACTIVIDAD");
                                    return;
                                }
                            }
                            act.Capacidad--;
                            cliente.inscribirActividad(act);
                            imprimirMensaje("INSCRIPCION EXITOSA");
                            return;
                        }
                    }
                    imprimirMensaje("ACTIVIDAD INEXISTENTE");
                    return;
                }
                imprimirMensaje("SOCIO INEXISTENTE");
                return;
            }
        }
    }
}
