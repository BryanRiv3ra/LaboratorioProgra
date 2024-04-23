using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class JuegoDisparos : VideoJuego
{
    public bool Disparos { get; set; }
    private List<string> armas = new List<string> { "Pistola", "Escopeta", "Rifle" };

    public string MostrarInformacionDisparos()
    {
        string informacion = $"Título: {Titulo}, Desarrolladora: {Desarrolladora}, Calificación: {Calificacion}, Año de Lanzamiento: {AnioLanzamiento}";
        return informacion;
    }

    public string ElegirArma()
    {
        Console.WriteLine($"Título: {Titulo}, Desarrolladora: {Desarrolladora}, Calificación: {Calificacion}, Año de Lanzamiento: {AnioLanzamiento}");
        Console.WriteLine($"Hay armas de fuego: {Disparos}");

        Console.WriteLine("Selecciona un arma:");
        for (int i = 0; i < armas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {armas[i]}");
        }

        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > armas.Count)
        {
            Console.WriteLine("Opción inválida. Ingresa un número válido.");
        }

        return armas[opcion - 1];
    }
}