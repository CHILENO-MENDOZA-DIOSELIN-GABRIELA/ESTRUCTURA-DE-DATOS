using System;

public class Ejercicio2
{
    public static void Ejecutar()
    {
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Por favor, ingresa un número entero: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Introduce un número entero válido.");
        }

        for (int i = 0; i < numero; i++)
        {
            Console.WriteLine(nombre);
        }
    }
}
