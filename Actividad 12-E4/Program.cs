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
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                            recomendacion = "Soporte tecnico";
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
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios < 3 && validacion == "2")
                        {
                            recomendacion = "Soporte al servidor";
                        }
                        else if (usuarios >= 10 && validacion == "3")
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
                case 3:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios < 3 && validacion == "2")
                        {
                            recomendacion = "Soporte tecnico";
                        }
                        else if (usuarios >= 5 && validacion == "4")
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
                case 4:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios > 2 && validacion == "1")
                        {
                            recomendacion = "Verificacion de la red";
                        }
                        else if (usuarios >= 6 && validacion == "4")
                        {
                            recomendacion = "Cida de la red, soporte de inmediato";
                        }
                        else
                        {
                            recomendacion = "Monitorar";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
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
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                            recomendacion = "Soporte tecnico";
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
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios < 3 && validacion == "2")
                        {
                            recomendacion = "Soporte al servidor";
                        }
                        else if (usuarios >= 10 && validacion == "3")
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
                case 3:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios < 3 && validacion == "2")
                        {
                            recomendacion = "Soporte tecnico";
                        }
                        else if (usuarios >= 5 && validacion == "4")
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
                case 4:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (usuarios > 2 && validacion == "1")
                        {
                            recomendacion = "Verificacion de la red";
                        }
                        else if (usuarios >= 6 && validacion == "4")
                        {
                            recomendacion = "Cida de la red, soporte de inmediato";
                        }
                        else
                        {
                            recomendacion = "Monitorar";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
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
            int afectado =int.Parse(Console.ReadLine());
            switch (afectado)
            {
                case 1:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para bloqueo de accseso no autrorizado pc";
                        }
                        else if ( validacion == "4")
                        {
                            recomendacion = "Soporte inmediado bloqueo de accseso no autrorizado en pc";
                        }
                        else
                        {
                            recomendacion = "soprte ocacional para psoibles bloqueos de accsesos no autrorizado en pc";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para bloqueo de accseso no autrorizado en el servidor";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado bloqueo de accseso no autrorizado en el servidor";
                        }
                        else
                        {
                            recomendacion = "soprte ocacional para psoibles bloqueos de accsesos no autrorizado en el servidor";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para bloqueo de accseso no autrorizado en la base de datos";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado bloqueo de accseso no autrorizado en la base de datos";
                        }
                        else
                        {
                            recomendacion = "soprte ocacional para psoibles bloqueos de accsesos no autrorizado en la base de datos";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para bloqueo de accseso no autrorizado en la red";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado bloqueo de accseso no autrorizado en la red";
                        }
                        else
                        {
                            recomendacion = "soprte ocacional para psoibles bloqueos de accsesos no autrorizado en la red";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
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
                            Console.WriteLine("¿Persistencia detectada? (S/N): ");
                            string persistencia = Console.ReadLine().ToUpper();
                            Console.WriteLine("Número de usuarios afectados: ");
                            int usuarios = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nivel de vaidacion: (1-4)");
                            string validacion = Console.ReadLine();
                            string severidad;
                            if (validacion == "1")
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
                            if (validacion == "3")
                            {
                                recomendacion = "Soporte para recuperacion de datos de la pc";
                            }
                            else if (validacion == "4")
                            {
                                recomendacion = "Soporte inmediado para recuperacion de datos de la pc";
                            }
                            else
                            {
                                recomendacion = "soprte prioritario para recuperacion de datos de la pc";
                            }
                            Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                            Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                                }
                            case 2:
                                {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para recuperacion de datos en el servidor";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado para recuperacion de datos en el servidor";
                        }
                        else
                        {
                            recomendacion = "soprte prioritario para recuperacion de datos en el servidor";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                                }
                            case 3:
                                {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para recuperacion de datos en la base de datos";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado para recuperacion de datos en la base de datos";
                        }
                        else
                        {
                            recomendacion = "soprte prioritario para recuperacion de datos en la base de datos";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
                        break;
                                }
                            case 4:
                                {
                        Console.WriteLine("¿Persistencia detectada? (S/N): ");
                        string persistencia = Console.ReadLine().ToUpper();
                        Console.WriteLine("Número de usuarios afectados: ");
                        int usuarios = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nivel de vaidacion: (1-4)");
                        string validacion = Console.ReadLine();
                        string severidad;
                        if (validacion == "1")
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
                        if (validacion == "3")
                        {
                            recomendacion = "Soporte para recuperacion de datos en la red";
                        }
                        else if (validacion == "4")
                        {
                            recomendacion = "Soporte inmediado para recuperacion de datos en la red";
                        }
                        else
                        {
                            recomendacion = "soprte prioritario para recuperacion de datos en la red";
                        }
                        Console.WriteLine($"RESULTADO DEL ANÁLISIS:");
                        Console.WriteLine($"Severidad: {severidad}");
                        Console.WriteLine($"Respuesta Sugerida: {recomendacion}");
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