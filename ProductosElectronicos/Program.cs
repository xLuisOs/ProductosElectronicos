using ProductosElectronicos;

GestorDispositivos gestor = new GestorDispositivos();
    bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Agregar Dispositivo (ordenador, tablet, telefono)");
            Console.WriteLine("2. Listar todos los dispositivos agregados");
            Console.WriteLine("3. Buscar por nombre");
            Console.WriteLine("4. Salir del programa");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            try
            {
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        AgregarDispositivo(gestor);
                        break;
                    case "2":
                        gestor.MostrarTodosDispositivos();
                        break;
                    case "3":
                        BuscarPorNombre(gestor);
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }

            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    

    static void AgregarDispositivo(GestorDispositivos gestor)
    {
        Console.WriteLine("Seleccione el tipo de dispositivo a agregar:");
        Console.WriteLine("1. Ordenador");
        Console.WriteLine("2. Tablet");
        Console.WriteLine("3. Teléfono");
        Console.Write("Seleccione una opción: ");
        string tipo = Console.ReadLine();

        try
        {
            string nombre = tipo switch
            {
                "1" => "Ordenador",
                "2" => "Tablet",
                "3" => "Teléfono",
                _ => throw new Exception("Tipo de dispositivo no válido")
            };

            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Sistema Operativo: ");
            string sistemaOperativo = Console.ReadLine();
            Console.Write("Almacenamiento: ");
            string almacenamiento = Console.ReadLine();
            Console.Write("Puerto de Carga: ");
            string puertoCarga = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    Console.Write("RAM: ");
                    string ram = Console.ReadLine();
                    Console.Write("Procesador: ");
                    string procesador = Console.ReadLine();
                    Console.Write("Tarjeta Gráfica: ");
                    string tarjetaGrafica = Console.ReadLine();

                    Ordenador ordenador = new Ordenador(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga, ram, procesador, tarjetaGrafica);
                    gestor.AgregarDispositivo(ordenador);
                    break;
                case "2":
                    Console.Write("Cámara: ");
                    int camara = int.Parse(Console.ReadLine());
                    Console.Write("Pantalla: ");
                    string pantalla = Console.ReadLine();
                    Console.Write("Batería: ");
                    string bateria = Console.ReadLine();

                    Movil tablet = new Movil(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga, camara, pantalla, bateria);
                    gestor.AgregarDispositivo(tablet);
                    break;
                case "3":
                    Console.Write("Cámara: ");
                    camara = int.Parse(Console.ReadLine());
                    Console.Write("Pantalla: ");
                    pantalla = Console.ReadLine();
                    Console.Write("Batería: ");
                    bateria = Console.ReadLine();
                    Console.Write("Compañía Telefónica: ");
                    string company = Console.ReadLine();
                    Console.Write("Ranura SIM: ");
                    int ranuraSim = int.Parse(Console.ReadLine());
                    Console.Write("Ranura SD: ");
                    int ranuraSD = int.Parse(Console.ReadLine());

                    Telefono telefono = new Telefono(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga, camara, pantalla, bateria, company, ranuraSim, ranuraSD);
                    gestor.AgregarDispositivo(telefono);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error en la entrada de datos: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    static void BuscarPorNombre(GestorDispositivos gestor)
    {
        Console.Write("Ingrese el nombre del dispositivo a buscar (Ordenador, Tablet, Teléfono): ");
        string nombre = Console.ReadLine().ToLower();

        try
        {
            List<Dispositivo> dispositivosEncontrados = gestor.BuscarPorNombre(nombre);

            if (dispositivosEncontrados.Count > 0)
            {
                Console.WriteLine($"Dispositivos encontrados con el nombre {nombre}:");
                foreach (var dispositivo in dispositivosEncontrados)
                {
                    dispositivo.MostrarDispositivo();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron dispositivos con el nombre {nombre}.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

