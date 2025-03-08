using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCOVID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Generar lista de 500 ciudadanos
            List<string> ciudadanos = GenerarCiudadanos(500);

            // Seleccionar 75 ciudadanos vacunados con Pfizer
            HashSet<string> vacunadosPfizer = SeleccionarCiudadanosAleatorios(ciudadanos, 75);

            // Seleccionar 75 ciudadanos vacunados con AstraZeneca
            HashSet<string> vacunadosAstraZeneca = SeleccionarCiudadanosAleatorios(ciudadanos, 75);

            // Ciudadanos vacunados con ambas vacunas (intersección)
            HashSet<string> ambasVacunas = new HashSet<string>(vacunadosPfizer);
            ambasVacunas.IntersectWith(vacunadosAstraZeneca);

            // Ciudadanos no vacunados (diferencia entre todos los ciudadanos y los vacunados)
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunadosPfizer);
            noVacunados.ExceptWith(vacunadosAstraZeneca);

            // Ciudadanos vacunados solo con Pfizer (diferencia entre Pfizer y AstraZeneca)
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);

            // Ciudadanos vacunados solo con AstraZeneca (diferencia entre AstraZeneca y Pfizer)
            HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);

            // Mostrar resultados
            MostrarLista("Ciudadanos NO vacunados", noVacunados);
            MostrarLista("Ciudadanos vacunados con ambas dosis", ambasVacunas);
            MostrarLista("Ciudadanos vacunados solo con Pfizer", soloPfizer);
            MostrarLista("Ciudadanos vacunados solo con AstraZeneca", soloAstraZeneca);
        }

        // Método para generar una lista de ciudadanos ficticios
        public static List<string> GenerarCiudadanos(int cantidad)
        {
            return Enumerable.Range(1, cantidad).Select(i => $"Ciudadano {i}").ToList();
        }

        // Método para seleccionar ciudadanos aleatorios
        public static HashSet<string> SeleccionarCiudadanosAleatorios(List<string> ciudadanos, int cantidad)
        {
            Random random = new Random();
            HashSet<string> seleccionados = new HashSet<string>();

            while (seleccionados.Count < cantidad)
            {
                int indice = random.Next(ciudadanos.Count);
                seleccionados.Add(ciudadanos[indice]);
            }

            return seleccionados;
        }

        // Método para mostrar una lista de ciudadanos
        public static void MostrarLista(string titulo, HashSet<string> conjunto)
        {
            Console.WriteLine($"\n{titulo} ({conjunto.Count} ciudadanos):");
            foreach (var ciudadano in conjunto)
            {
                Console.WriteLine(ciudadano);
            }
        }
    }
}