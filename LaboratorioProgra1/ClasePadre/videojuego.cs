using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.ClasePadre
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo { get; set; }
        private string desarrolladora { get; set; }
        private double calificacion { get; set; }
        private int anioLanzamiento { get; set; } //se cambio a {get; set;}  
        private bool jugando = true;
        public int _anioLanzamiento;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
              
                if (value >= 0 || value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }

            }
        }

        public int AnioLanzamiento
        {
            get { return _anioLanzamiento; }
            set
            {
                if (value >= 1950 || value <= 2025)
                {
                    _anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("La fecha de lanzamiento no puede ser mayor al año actual.");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + _anioLanzamiento);
            Console.WriteLine(saludo);
            Console.WriteLine(IniciarPartida);
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida() //no hacia nada el metodo
        {
            if (jugando)
            {
                Console.WriteLine("Partida detenida.");
                jugando = false;
             
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

        public void TerminarJuego() //no hacia nada el metodo 
        {
            if (jugando == true)
            {

                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }
       
    }
}
