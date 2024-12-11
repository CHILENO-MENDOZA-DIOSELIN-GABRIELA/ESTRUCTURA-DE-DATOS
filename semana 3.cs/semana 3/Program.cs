/*
    UNIVERSIDAD ESTATAL AMAZÓNICA
    Nombre: Chileno Mendoza Dioselin Gabriela
    Docente: Ortega Tenezaca Delfin Bernabe
    Tema: Arrays y matrices
*/
using System;

namespace RegistroProductos
{
    // Definición de la clase Producto
    public class Producto
    {
        public int Id { get; set; } // Identificador único del producto
        public string Nombre { get; set; } // Nombre del producto
        public string Unidad { get; set; } // Unidad de medida (ejemplo: "kg", "unidad")
        public decimal[] Precios { get; set; } // Manejo de tres precios

        // Constructor de la clase
        public Producto(int id, string nombre, string unidad, decimal[] precios)
        {
            Id = id;
            Nombre = nombre;
            Unidad = unidad;
            Precios = precios;
        }

        // Método para mostrar información del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Unidad: {Unidad}");
            Console.WriteLine($"Precios: {string.Join(", ", Precios)}"); // Usamos string.Join para mostrar todos los precios
            Console.WriteLine("------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de un array de productos
            Producto[] productos = new Producto[3];

            // Inicialización de productos
            productos[0] = new Producto(1, "Producto A", "Unidad", new decimal[] { 1.50m, 1.70m, 1.90m });
            productos[1] = new Producto(2, "Producto B", "Kilogramo", new decimal[] { 2.00m, 2.30m, 2.50m });
            productos[2] = new Producto(3, "Producto C", "Unidad", new decimal[] { 3.00m, 3.20m, 3.50m });

            // Mostrar información de los productos
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
    }
}
