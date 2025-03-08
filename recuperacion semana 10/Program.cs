using System;
using System.Collections.Generic;
using System.Linq;

namespace RegistroVacunas
{
    public class ControlVacunacion
    {
        public static void Main(string[] args)
        {
            // Nombre: Chileno Mendoza Dioselin Gabriela
            // Docente: Ortega Tenezaca Delfin Bernabe

            // Generar lista de ciudadanos
            List<string> poblacion = GenerarPoblacion(500);

            // Asignar vacunas aleatoriamente
            HashSet<string> vacunadosModerna = new HashSet<string>(SeleccionarAleatorio(poblacion, 80));
            HashSet<string> vacunadosSinovac = new HashSet<string>(SeleccionarAleatorio(poblacion, 80));

            // Determinar ciudadanos con ambas vacunas
            HashSet<string> dobleDosis = new HashSet<string>(vacunadosModerna);
            dobleDosis.IntersectWith(vacunadosSinovac);

            // Determinar ciudadanos no vacunados
            HashSet<string> vacunados = new HashSet<string>(dobleDosis.Union(vacunadosModerna).Union(vacunadosSinovac));
            HashSet<string> sinVacuna = new HashSet<string>(poblacion.Except(vacunados));

            // Determinar ciudadanos con una sola dosis
            HashSet<string> soloModerna = new HashSet<string>(vacunadosModerna.Except(vacunadosSinovac));
            HashSet<string> soloSinovac = new HashSet<string>(vacunadosSinovac.Except(vacunadosModerna));

            // Mostrar resultados
            MostrarResultados("Personas NO vacunadas", sinVacuna);
            MostrarResultados("Personas con ambas dosis", dobleDosis);
            MostrarResultados("Personas con solo Moderna", soloModerna);
            MostrarResultados("Personas con solo Sinovac", soloSinovac);
        }

        // Generar lista de ciudadanos
        public static List<string> GenerarPoblacion(int cantidad)
        {
            return Enumerable.Range(1, cantidad).Select(i => $"Persona {i}").ToList();
        }

        // Seleccionar aleatoriamente ciudadanos
        public static List<string> SeleccionarAleatorio(List<string> lista, int cantidad)
        {
            return lista.OrderBy(_ => Guid.NewGuid()).Take(cantidad).ToList();
        }

        // Método para mostrar resultados
        public static void MostrarResultados(string titulo, HashSet<string> grupo)
        {
            Console.WriteLine($"\n{titulo} ({grupo.Count} personas):");
            foreach (var persona in grupo)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
