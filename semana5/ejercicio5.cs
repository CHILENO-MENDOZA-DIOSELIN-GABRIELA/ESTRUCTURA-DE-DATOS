using System;
using System.Collections.Generic;

public class Ejercicio5
{
    public static void Ejecutar()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        List<int> notas = new List<int>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Nota para {asignatura}: ");
            int nota;
            while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Introduce una nota válida (0-100): ");
            }
            notas.Add(nota);
        }

        Console.WriteLine("Tus notas:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}.");
        }
    }
}
