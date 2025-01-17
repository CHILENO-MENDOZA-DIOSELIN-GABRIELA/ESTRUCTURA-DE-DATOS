using System;
using System.Collections.Generic;

public class Lista
{
    private List<int> elementos;

    public Lista()
    {
        elementos = new List<int>();
    }

    public void AgregarElemento(int elemento)
    {
        elementos.Add(elemento);
    }

    public int BuscarDato(int dato)
    {
        int contador = 0;

        foreach (int elemento in elementos)
        {
            if (elemento == dato)
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"El dato {dato} se encontró {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El dato {dato} no fue encontrado en la lista.");
        }

        return contador;
    }

    public void MostrarElementos()
    {
        Console.WriteLine("Elementos de la lista: " + string.Join(", ", elementos));
    }
}
