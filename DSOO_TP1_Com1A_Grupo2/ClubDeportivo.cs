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
                MostrarMenu();
                opcion = LeerOpcion();
                EjecutarOpcion(opcion, clientes, actividades);
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Bienvenido al Club Deportivo");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Eliminar Cliente");
            Console.WriteLine("3. Listar Clientes");
            Console.WriteLine("4. Inscribir cliente a una actividad");
            Console.WriteLine("5. Listar actividades de un cliente");
            Console.WriteLine("6. Salir");
        }

        static int LeerOpcion()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return 0;
            }
        }

        static void EjecutarOpcion(int opcion, Clientes clientes, Actividades actividades)
        {
            switch (opcion)
            {
                case 1:
                    AgregarCliente(clientes);
                    break;
                case 2:
                    EliminarCliente(clientes);
                    break;
                case 3:
                    ListarClientes(clientes);
                    break;
                case 4:
                    InscribirClienteActividad(clientes, actividades);
                    break;
                case 5:
                    ListarActividadesCliente(clientes);
                    break;
                case 6:
                    break;
                default:
                    imprimirMensaje("Ingrese un numero válido");
                    break;
            }
        }

        static void AgregarCliente(Clientes clientes)
        {
            string nombre = LeerEntrada("Nombre");
            string apellido = LeerEntrada("Apellido");
            string email = LeerEntrada("Email");
            string dni = LeerEntrada("DNI");
            string telefono = LeerEntrada("Teléfono");

            Console.Clear();
            if (clientes.altaSocio(nombre, apellido, email, dni, telefono, true))
            {
                imprimirMensaje("\n\nCliente agregado correctamente");
            }
            else
            {
                imprimirMensaje("El cliente ya existe");
            }
        }

        static void EliminarCliente(Clientes clientes)
        {
            string dni = LeerEntrada("DNI del cliente a eliminar");
            if (clientes.eliminarCliente(dni))
            {
                imprimirMensaje("Cliente eliminado correctamente");
            }
            else
            {
                imprimirMensaje("El cliente no existe");
            }
        }

        static void ListarClientes(Clientes clientes)
        {
            clientes.listarClientes();
            Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void InscribirClienteActividad(Clientes clientes, Actividades actividades)
        {
            string dni = LeerEntrada("DNI del cliente");
            string actividad = LeerEntrada("Nombre de la actividad");
            inscribirActividad(dni, actividad, clientes, actividades);
        }

        static void ListarActividadesCliente(Clientes clientes)
        {
            string dni = LeerEntrada("DNI del cliente");
            Cliente? cliente = clientes.buscarCliente(dni, false);
            if (cliente != null)
            {
                cliente.listarActividades();
            }
        }

        static string LeerEntrada(string campo)
        {
            string? entrada;
            do
            {
                Console.Write($"{campo}: ");
                entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine($"El {campo} no puede estar vacío.");
                }
            } while (string.IsNullOrEmpty(entrada));
            return entrada;
        }

        static void imprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Thread.Sleep(2000);
            Console.Clear();
        }

        static void inscribirActividad(string dni, string actividad, Clientes clientes, Actividades actividades)
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