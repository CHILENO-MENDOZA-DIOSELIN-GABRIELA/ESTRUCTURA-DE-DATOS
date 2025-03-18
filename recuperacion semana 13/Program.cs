using System;

// Definición del nodo del árbol binario
public class Nodo
{
    public string Titulo;
    public Nodo Izquierdo, Derecho;

    public Nodo(string titulo)
    {
        Titulo = titulo;
        Izquierdo = Derecho = null;
    }
}

// Definición del árbol binario de búsqueda
public class ArbolBinario
{
    private Nodo raiz;

    public ArbolBinario()
    {
        raiz = null;
    }

    // Método para insertar un título en el árbol
    public void Insertar(string titulo)
    {
        raiz = InsertarRec(raiz, titulo);
    }

    private Nodo InsertarRec(Nodo raiz, string titulo)
    {
        if (raiz == null)
            return new Nodo(titulo);

        if (string.Compare(titulo, raiz.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, titulo);
        else
            raiz.Derecho = InsertarRec(raiz.Derecho, titulo);

        return raiz;
    }

    // Método para buscar un título en el árbol
    public string Buscar(string titulo)
    {
        return BuscarRec(raiz, titulo) ? "encontrado" : "no encontrado";
    }

    private bool BuscarRec(Nodo raiz, string titulo)
    {
        if (raiz == null)
            return false;
        
        int comparacion = string.Compare(titulo, raiz.Titulo, StringComparison.OrdinalIgnoreCase);
        if (comparacion == 0)
            return true;
        
        if (comparacion < 0)
            return BuscarRec(raiz.Izquierdo, titulo);
        else
            return BuscarRec(raiz.Derecho, titulo);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Información del autor y docente
        string nombre = "CHILENO MENDOZA DIOSELIN GABRIELA";
        string docente = "ORTEGA TENEZACA DELFIN BERNABE";
        string fecha = DateTime.Now.ToString("dd/MM/yyyy");

        Console.WriteLine($"NOMBRE: {nombre}");
        Console.WriteLine($"DOCENTE: {docente}");
        Console.WriteLine($"FECHA: {fecha}\n");

        ArbolBinario catalogo = new ArbolBinario();

        // Insertar títulos en el árbol
        string[] titulos =
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

        foreach (string titulo in titulos)
        {
            catalogo.Insertar(titulo);
        }

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
                        Console.WriteLine($"Resultado: {catalogo.Buscar(tituloBuscado)}\n");
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
