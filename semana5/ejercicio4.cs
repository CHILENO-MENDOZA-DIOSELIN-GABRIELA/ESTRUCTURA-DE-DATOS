using System;
using System.Collections.Generic;

public class Ejercicio4
{
    public static void Ejecutar()
    {
        Dictionary<string, (double precio, double porcentaje)> cesta = new Dictionary<string, (double, double)>
        {
            { "Producto1", (100.0, 10.0) },
            { "Producto2", (200.0, 15.0) },
            { "Producto3", (50.0, 5.0) }
        };

        double totalConDescuento = CalcularPrecioFinal(cesta, AplicarDescuento);
        Console.WriteLine($"Precio final con descuento: {totalConDescuento}");

        double totalConIVA = CalcularPrecioFinal(cesta, AplicarIVA);
        Console.WriteLine($"Precio final con IVA: {totalConIVA}");
    }

    static double AplicarDescuento(double precio, double porcentaje)
    {
        return precio - (precio * porcentaje / 100);
    }

    static double AplicarIVA(double precio, double porcentaje)
    {
        return precio + (precio * porcentaje / 100);
    }

    static double CalcularPrecioFinal(Dictionary<string, (double precio, double porcentaje)> cesta, Func<double, double, double> operacion)
    {
        double total = 0;
        foreach (var producto in cesta)
        {
            double precioFinal = operacion(producto.Value.precio, producto.Value.porcentaje);
            total += precioFinal;
        }
        return total;
    }
}
