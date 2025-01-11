using System;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        string nombreMayusculas = nombre.ToUpper();
        int numeroLetras = nombre.Replace(" ", "").Length;

        Console.WriteLine($"{nombreMayusculas} tiene {numeroLetras} letras.");
    }
}
