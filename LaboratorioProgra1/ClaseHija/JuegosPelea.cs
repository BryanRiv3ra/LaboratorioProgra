using LaboratorioProgra1.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClaseHija
{
    internal class JuegosPelea : VideoJuego
    {
        public bool Combates { get; set; }
        private List<string> personajes = new List<string> { "Kyo", "Iori", "Mai", "Kula", "Orochi" };
        public string MostrarInformacioCombates()
        {
            string informacion = $"Título: {Titulo}, Desarrolladora: {Desarrolladora}, Calificación: {Calificacion}, Año de Lanzamiento: {AnioLanzamiento}";
            return informacion;
        }
        public string ElegirPersonaje()
        {
            Console.WriteLine("Selecciona un personaje:");
            for (int i = 0; i < personajes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {personajes[i]}");
            }

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > personajes.Count)
            {
                Console.WriteLine("Opción inválida. Ingresa un número válido.");
            }

            return personajes[opcion - 1];
        }

    }
}

