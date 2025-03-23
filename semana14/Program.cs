using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierda;
    public Nodo Derecha;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierda = null;
        Derecha = null;
    }
}

class ArbolBinario
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        if (Raiz == null)
        {
            Raiz = new Nodo(valor);
        }
        else
        {
            InsertarRecursivo(Raiz, valor);
        }
    }

    private void InsertarRecursivo(Nodo nodo, int valor)
    {
        if (valor < nodo.Valor)
        {
            if (nodo.Izquierda == null)
            {
                nodo.Izquierda = new Nodo(valor);
            }
            else
            {
                InsertarRecursivo(nodo.Izquierda, valor);
            }
        }
        else
        {
            if (nodo.Derecha == null)
            {
                nodo.Derecha = new Nodo(valor);
            }
            else
            {
                InsertarRecursivo(nodo.Derecha, valor);
            }
        }
    }

    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierda);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecha);
        }
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierda);
            Preorden(nodo.Derecha);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierda);
            Postorden(nodo.Derecha);
            Console.Write(nodo.Valor + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Información del estudiante
        Console.WriteLine("NOMBRE: DIOSELIN GABRIELA CHILENO MENDOZA");
        Console.WriteLine("DOCENTE: ORTEGA TENEZACA DELFIN BERNABE");
        Console.WriteLine("FECHA: 2025-03-23"); // Puedes cambiar la fecha si es necesario
        
        ArbolBinario arbol = new ArbolBinario();
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Insertar un valor");
            Console.WriteLine("2. Mostrar en orden");
            Console.WriteLine("3. Mostrar en preorden");
            Console.WriteLine("4. Mostrar en postorden");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese un valor entero: ");
                int valor;
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    arbol.Insertar(valor);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero válido.");
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Recorrido en orden:");
                arbol.Inorden(arbol.Raiz);
                Console.WriteLine();
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Recorrido en preorden:");
                arbol.Preorden(arbol.Raiz);
                Console.WriteLine();
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Recorrido en postorden:");
                arbol.Postorden(arbol.Raiz);
                Console.WriteLine();
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa.");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}