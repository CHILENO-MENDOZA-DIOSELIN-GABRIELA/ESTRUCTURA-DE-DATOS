using System;
using System.Collections.Generic;

namespace Vacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear conjunto ficticio de 500 ciudadanos
            HashSet<string> totalCiudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                totalCiudadanos.Add($"ciudadano_{i}");
            }

            // Crear conjunto ficticio de 75 ciudadanos vacunados con Pfizer
            HashSet<string> vacunadosPfizer = new HashSet<string>();
            Random rand = new Random();
            while (vacunadosPfizer.Count < 75)
            {
                vacunadosPfizer.Add($"ciudadano_{rand.Next(1, 501)}");
            }

            // Crear conjunto ficticio de 75 ciudadanos vacunados con Astrazeneca
            HashSet<string> vacunadosAstrazeneca = new HashSet<string>();
            while (vacunadosAstrazeneca.Count < 75)
            {
                vacunadosAstrazeneca.Add($"ciudadano_{rand.Next(1, 501)}");
            }

            // Listado de ciudadanos que no se han vacunado
            HashSet<string> noVacunados = new HashSet<string>(totalCiudadanos);
            noVacunados.ExceptWith(vacunadosPfizer);
            noVacunados.ExceptWith(vacunadosAstrazeneca);

            // Listado de ciudadanos que han recibido las dos vacunas
            HashSet<string> vacunadosDos = new HashSet<string>(vacunadosPfizer);
            vacunadosDos.IntersectWith(vacunadosAstrazeneca);

            // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstrazeneca);

            // Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca
            HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca);
            soloAstrazeneca.ExceptWith(vacunadosPfizer);

            // Mostrar los resultados
            Console.WriteLine("Ciudadanos no vacunados:");
            foreach (var ciudadano in noVacunados)
            {
                Console.WriteLine(ciudadano);
            }

            Console.WriteLine("\nCiudadanos vacunados con las dos vacunas:");
            foreach (var ciudadano in vacunadosDos)
            {
                Console.WriteLine(ciudadano);
            }

            Console.WriteLine("\nCiudadanos vacunados solo con Pfizer:");
            foreach (var ciudadano in soloPfizer)
            {
                Console.WriteLine(ciudadano);
            }

            Console.WriteLine("\nCiudadanos vacunados solo con Astrazeneca:");
            foreach (var ciudadano in soloAstrazeneca)
            {
                Console.WriteLine(ciudadano);
            }
        }
    }
}
