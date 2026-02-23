Console.WriteLine("MENU");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de información");
Console.WriteLine("Seleccionar una opción: ");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        {
            Console.WriteLine("Activo afectado");
            Console.WriteLine("1. PC");
            Console.WriteLine("2. Servidor");
            Console.WriteLine("3. Base de datos");
            Console.WriteLine("4. Red");
            Console.WriteLine("Seleccionar una opción: ");
            int afectado = int.Parse(Console.ReadLine());
            switch (afectado)
            {
                case 1:
                    {
                        Console.Write("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.Write("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion= Console.ReadLine();
                        string severidad;
                        if (validacion =="1")
                        {
                            severidad = "Baja";
                        }
                        else 
                        {
                            if (validacion == "2")
                            {
                                severidad = "Media";
                            }
                            else if (validacion == "3")
                            {
                                severidad = "Alta";
                            }
                            else
                            {
                                severidad = "Critica";
                            }
                        }
                        string recomendacion;
                        if (usuarios < 5 && validacion == "1")
                        { 
                            recomendacion= "Soporte tecnico";
                        }
                        else if (usuarios >= 50 && validacion == "3")
                        {
                            recomendacion = "Bloqueo";
                        }
                        else
                        {
                            recomendacion = "Monitoreo";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("Activo afectado");
            Console.WriteLine("1. PC");
            Console.WriteLine("2. Servidor");
            Console.WriteLine("3. Base de datos");
            Console.WriteLine("4. Red");
            Console.WriteLine("Seleccionar una opción: ");
            int afectado = int.Parse(Console.ReadLine());
            switch (afectado)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("Activo afectado");
            Console.WriteLine("1. PC");
            Console.WriteLine("2. Servidor");
            Console.WriteLine("3. Base de datos");
            Console.WriteLine("4. Red");
            Console.WriteLine("Seleccionar una opción: ");
            int afectado = int.Parse(Console.ReadLine());
            switch (afectado)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 4:
        {
            Console.WriteLine("Activo afectado");
            Console.WriteLine("1. PC");
            Console.WriteLine("2. Servidor");
            Console.WriteLine("3. Base de datos");
            Console.WriteLine("4. Red");
            Console.WriteLine("Seleccionar una opción: ");
            int afectado = int.Parse(Console.ReadLine());
            switch (afectado)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    default:
        {
            Console.WriteLine("Opción no válida");
        }
        break;
}