using System;

public class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;

    public ListaEnlazada()
    {
        Cabeza = null;
    }

    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void Eliminar(int valor)
    {
        if (Cabeza == null)
        {
            Console.WriteLine("La lista está vacía. No se puede eliminar el valor.");
            return;
        }

        if (Cabeza.Valor == valor)
        {
            Cabeza = Cabeza.Siguiente;
            Console.WriteLine($"El nodo con el valor {valor} fue eliminado.");
            return;
        }

        Nodo actual = Cabeza;
        Nodo anterior = null;

        while (actual != null && actual.Valor != valor)
        {
            anterior = actual;
            actual = actual.Siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($"El valor {valor} no se encontró en la lista.");
        }
        else
        {
            anterior.Siguiente = actual.Siguiente;
            Console.WriteLine($"El nodo con el valor {valor} fue eliminado.");
        }
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = Cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    public void Imprimir()
    {
        Nodo actual = Cabeza;

        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }

        Console.WriteLine("null");
    }
}
