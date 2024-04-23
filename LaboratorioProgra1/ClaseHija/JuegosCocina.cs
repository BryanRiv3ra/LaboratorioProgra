using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class JuegosCocina : VideoJuego
{
    public bool Cocina { get; set; }
    private List<string> recetas = new List<string> { "Caldo de pollo", "Puré de papa", "Pizza" };

    public string MostrarInformacionCocina()
    {
        string informacion = $"Título: {Titulo}, Desarrolladora: {Desarrolladora}, Calificación: {Calificacion}, Año de Lanzamiento: {AnioLanzamiento}";
        return informacion;
    }

    public string ElegirReceta()
    {
        Console.WriteLine("Selecciona una receta:");
        for (int i = 0; i < recetas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recetas[i]}");
        }

        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > recetas.Count)
        {
            Console.WriteLine("Opción inválida. Ingresa un número válido.");
        }

        string recetaSeleccionada = recetas[opcion - 1];
        Console.WriteLine($"Has elegido la receta: {recetaSeleccionada}");

        return recetas[opcion - 1];
    }
}
