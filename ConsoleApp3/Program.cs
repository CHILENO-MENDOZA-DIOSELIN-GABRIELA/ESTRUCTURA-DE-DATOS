using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear la cesta de la compra (producto, precio, porcentaje)
        Dictionary<string, (double precio, double porcentaje)> cesta = new Dictionary<string, (double, double)>
        {
            { "Producto1", (100.0, 10.0) }, // 100 de precio, 10% de descuento o IVA
            { "Producto2", (200.0, 15.0) },
            { "Producto3", (50.0, 5.0) }
        };

        // Calcular el precio final aplicando el descuento
        double totalConDescuento = CalcularPrecioFinal(cesta, AplicarDescuento);
        Console.WriteLine($"Precio final con descuento: {totalConDescuento}");

        // Calcular el precio final aplicando el IVA
        double totalConIVA = CalcularPrecioFinal(cesta, AplicarIVA);
        Console.WriteLine($"Precio final con IVA: {totalConIVA}");
    }

    // Función para aplicar un descuento a un precio
    static double AplicarDescuento(double precio, double porcentaje)
    {
        return precio - (precio * porcentaje / 100);
    }

    // Función para aplicar el IVA a un precio
    static double AplicarIVA(double precio, double porcentaje)
    {
        return precio + (precio * porcentaje / 100);
    }

    // Función para calcular el precio final de la cesta
    static double CalcularPrecioFinal(Dictionary<string, (double precio, double porcentaje)> cesta, Func<double, double, double> operacion)
    {
        double total = 0;

        foreach (var producto in cesta)
        {
            string nombre = producto.Key;
            double precio = producto.Value.precio;
            double porcentaje = producto.Value.porcentaje;

            // Aplicar la operación (descuento o IVA) al producto
            double precioFinal = operacion(precio, porcentaje);
            total += precioFinal;

            Console.WriteLine($"{nombre}: Precio original = {precio}, Porcentaje = {porcentaje}%, Precio final = {precioFinal}");
        }

        return total;
    }
}
