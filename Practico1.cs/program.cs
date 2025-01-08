using System;
using System.Collections.Generic;

namespace RegistroAportes
{
    // Clase Miembro
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<decimal> Aportes { get; set; }

        // Constructor
        public Miembro(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Aportes = new List<decimal>();
        }

        // Método para registrar un aporte
        public void RegistrarAporte(decimal monto)
        {
            Aportes.Add(monto);
        }

        // Método para consultar el total de los aportes
        public decimal ConsultarAportes()
        {
            decimal total = 0;
            foreach (var aporte in Aportes)
            {
                total += aporte;
            }
            return total;
        }
    }

    // Clase para manejar el registro de aportes
    public class SistemaAportes
    {
        private List<Miembro> miembros;

        public SistemaAportes()
        {
            miembros = new List<Miembro>();
        }

        // Método para agregar un miembro al sistema
        public void AgregarMiembro(Miembro miembro)
        {
            miembros.Add(miembro);
        }

        // Método para mostrar todos los miembros
        public void MostrarMiembros()
        {
            foreach (var miembro in miembros)
            {
                Console.WriteLine($"ID: {miembro.Id}, Nombre: {miembro.Nombre}");
            }
        }

        // Método para generar un reporte de todos los aportes
        public void GenerarReporte()
        {
            foreach (var miembro in miembros)
            {
                Console.WriteLine($"Miembro: {miembro.Nombre}, Total Aportes: {miembro.ConsultarAportes()}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear el sistema de aportes
            SistemaAportes sistema = new SistemaAportes();

            // Crear miembros
            Miembro miembro1 = new Miembro(1, "Dioselin Mendoza");
            Miembro miembro2 = new Miembro(2, "Carmen Sisa");

            // Registrar aportes
            miembro1.RegistrarAporte(100.50m);
            miembro1.RegistrarAporte(200.75m);

            miembro2.RegistrarAporte(150.00m);

            // Agregar miembros al sistema
            sistema.AgregarMiembro(miembro1);
            sistema.AgregarMiembro(miembro2);

            // Mostrar los miembros registrados
            Console.WriteLine("Miembros registrados:");
            sistema.MostrarMiembros();

            // Generar reporte de aportes
            Console.WriteLine("\nReporte de aportes:");
            sistema.GenerarReporte();

            // Esperar para que el usuario vea la salida
            Console.ReadLine();
        }
    }
}
