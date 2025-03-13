using System;
using System.Collections.Generic;

public class CatalogoRevistas
{
    private List<string> titulos;

    public CatalogoRevistas()
    {
        // Inicializar la lista de títulos con revistas predefinidas
        titulos = new List<string>
        {
            "Revista de Educacion para la Ciudadania",
            "Revista de Tecnología",
            "Revista de Salud",
            "Revista de Educación",
            "Revista de Historia",
            "Revista de Arte",
            "Revista de Literatura",
            "Revista de Deportes",
            "Revista de Economía",
            "Revista de Medio Ambiente"
        };
    }

    public string BuscarTitulo(string tituloBuscado)
    {
        foreach (string titulo in titulos)
        {
            if (titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase)) // Ignora mayúsculas/minúsculas
            {
                return "encontrado";
            }
        }
        return "no encontrado";
    }

    public static void Main(string[] args)
    {
        // Información del autor y docente
        string nombre = "CHILENO MENDOZA DIOSELIN GABRIELA";
        string docente = "ORTEGA TENEZACA DELFIN BERNABE";
        string fecha = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha actual

        // Mostrar información
        Console.WriteLine($"NOMBRE: {nombre}");
        Console.WriteLine($"DOCENTE: {docente}");
        Console.WriteLine($"FECHA: {fecha}");
        Console.WriteLine();

        CatalogoRevistas catalogo = new CatalogoRevistas();

        int opcion;
        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Ingrese su opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloBuscado = Console.ReadLine();
                        string resultado = catalogo.BuscarTitulo(tituloBuscado);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número.");
            }
        } while (opcion != 2);
    }
}