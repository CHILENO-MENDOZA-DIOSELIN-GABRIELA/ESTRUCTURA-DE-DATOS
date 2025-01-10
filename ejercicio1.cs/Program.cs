using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista que almacena las asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Mostrar el mensaje por cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }

        // Espera para que el usuario pueda ver el resultado
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
