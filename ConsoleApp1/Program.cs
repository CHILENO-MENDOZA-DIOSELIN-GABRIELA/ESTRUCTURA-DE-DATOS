using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista que almacena las asignaturas
        List<string> asignaturas = new List<string>
        {
            "Sistema",
            "Fisica",
            "Química",
            "Historia",
            "ingles"
        };

        // Lista para almacenar las notas ingresadas por el usuario
        List<int> notas = new List<int>();

        Console.WriteLine("Introduce la nota para cada asignatura:");

        // Solicitar al usuario las notas para cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Nota para {asignatura}: ");
            int nota;
            
            // Validar entrada para asegurarse de que sea un número
            while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Por favor, introduce una nota válida (entre 0 y 100):");
            }
            
            notas.Add(nota);
        }

        // Mostrar las asignaturas con las notas
        Console.WriteLine("\nTus notas:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}.");
        }

        // Esperar a que el usuario cierre el programa
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
