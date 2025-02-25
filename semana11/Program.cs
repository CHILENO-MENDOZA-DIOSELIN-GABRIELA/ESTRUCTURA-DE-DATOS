using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Información del autor y docente
        Console.WriteLine("Nombre: Chileno Mendoza Dioselin Gabriela");
        Console.WriteLine("Docente: ING. Tenezaca Ortega Delfin Bernabe");
        Console.WriteLine("Fecha: 25/02/2025");
        Console.WriteLine();

        // Diccionario inicial con palabras en inglés y español
        Dictionary<string, string> diccionario = new Dictionary<string, string>
        {
            { "time", "tiempo" },
            { "person", "persona" },
            { "year", "año" },
            { "way", "camino" },
            { "day", "día" },
            { "thing", "cosa" },
            { "man", "hombre" },
            { "world", "mundo" },
            { "life", "vida" },
            { "hand", "mano" },
            { "part", "parte" },
            { "child", "niño/a" },
            { "eye", "ojo" },
            { "woman", "mujer" },
            { "place", "lugar" },
            { "work", "trabajo" },
            { "week", "semana" },
            { "case", "caso" },
            { "point", "punto/tema" },
            { "government", "gobierno" },
            { "company", "empresa/compañía" }
        };

        while (true)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                // Frase de ejemplo en inglés
                string fraseOriginalIngles = "This day is beautiful, it depends a lot on the eye that sees it.";
                Console.WriteLine("Ingrese la frase: " + fraseOriginalIngles);
                // Traducir la frase al español
                string fraseTraducida = TraducirFrase(fraseOriginalIngles, diccionario);
                Console.WriteLine("Su frase traducida es: " + fraseTraducida);
            }
            else if (opcion == "2")
            {
                AgregarPalabra(diccionario);
            }
            else if (opcion == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }

    static string TraducirFrase(string frase, Dictionary<string, string> diccionario)
    {
        string[] palabras = frase.Split(' ');
        List<string> palabrasTraducidas = new List<string>();

        foreach (string palabra in palabras)
        {
            string palabraEnMinusculas = palabra.ToLower().Trim(new char[] { '.', ',', '!', '?' });
            if (diccionario.ContainsKey(palabraEnMinusculas))
            {
                palabrasTraducidas.Add(diccionario[palabraEnMinusculas]);
            }
            else
            {
                palabrasTraducidas.Add(palabra); // Si no está en el diccionario, se mantiene la palabra original
            }
        }

        return string.Join(" ", palabrasTraducidas);
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string palabraIngles = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string traduccionEspanol = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(palabraIngles))
        {
            diccionario.Add(palabraIngles, traduccionEspanol);
            Console.WriteLine("Palabra agregada al diccionario.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}