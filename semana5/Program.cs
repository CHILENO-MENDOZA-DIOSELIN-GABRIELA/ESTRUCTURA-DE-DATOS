using System;

class Program
{
    static void Main()
    {
        // Solicitar el nombre del usuario
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Convertir el nombre a mayúsculas
        string nombreMayusculas = nombre.ToUpper();

        // Calcular el número de letras (ignorando espacios)
        int numeroLetras = nombre.Replace(" ", "").Length;

        // Mostrar el mensaje en pantalla
        Console.WriteLine($"{nombreMayusculas} tiene {numeroLetras} letras.");

        // Esperar a que el usuario cierre el programa
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
