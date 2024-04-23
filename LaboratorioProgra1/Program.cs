using LaboratorioProgra1.ClasePadre;
using LaboratorioProgra1.ClaseHija;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Juego de Disparos");
            Console.WriteLine("2. Juego de Cocina");
            Console.WriteLine("3. Juego de Combates");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Disparos();
                    break;
                case "2":
                    Cocina();
                    break;
                case "3":
                    Combates();
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void Disparos()
    {
        JuegoDisparos Tiros = new JuegoDisparos();
        Tiros.Titulo = "Call of duty: Black ops 2";
        Tiros.Desarrolladora = "Activision";
        Tiros.Calificacion = 10;
        Tiros._anioLanzamiento = 2012;
        while (true)
        {
            Console.WriteLine(Tiros.MostrarInformacionDisparos());

            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Iniciar partida");
            Console.WriteLine("2. Detener partida");
            Console.WriteLine("3. Terminar juego");


            string elegir = Console.ReadLine();

            switch (elegir)
            {
                case "1":
                    Tiros.IniciarPartida();
                    string armaElegida = Tiros.ElegirArma();
                    Console.WriteLine($"has elegido la {armaElegida} para el combate.");
                    break;
                case "2":
                    Tiros.DetenerPartida();
                    break;
                case "3":
                    Tiros.TerminarJuego();
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void Cocina()
    {
        JuegosCocina Comida = new JuegosCocina();
        Comida.Titulo = "overcooked";
        Comida.Desarrolladora = "Ghost Town Games";
        Comida.Calificacion = 10;
        Comida._anioLanzamiento = 2016;
        while (true)
        {
            Console.WriteLine(Comida.MostrarInformacionCocina());

            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Iniciar partida");
            Console.WriteLine("2. Detener partida");
            Console.WriteLine("3. Terminar juego");

            string elegir = Console.ReadLine();

            switch (elegir)
            {
                case "1":
                    Comida.IniciarPartida();
                    string recetaSeleccionada = Comida.ElegirReceta();
                    Console.WriteLine($"Has elegido la {recetaSeleccionada} para cocinar y entregar.");
                    break;
                case "2":
                    Comida.DetenerPartida();
                    break;
                case "3":
                    Comida.TerminarJuego();
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void Combates()
    {
        JuegosPelea Combate = new JuegosPelea();
        Combate.Titulo = "King of fighters";
        Combate.Desarrolladora = "SNK";
        Combate.Calificacion = 10;
        Combate._anioLanzamiento = 2023;
        while (true)
        {
            Console.WriteLine(Combate.MostrarInformacioCombates());

            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1. Iniciar partida");
            Console.WriteLine("2. Detener partida");
            Console.WriteLine("3. Terminar juego");
            Console.WriteLine("4. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Combate.IniciarPartida();
                    Console.WriteLine(Combate.MostrarInformacioCombates());
                    string personajeElegido = Combate.ElegirPersonaje();
                    Console.WriteLine($"Has elegido a {personajeElegido} como tu personaje.");
                    break;
                case "2":
                    Combate.DetenerPartida();
                    break;
                case "3":
                    Combate.TerminarJuego();
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
