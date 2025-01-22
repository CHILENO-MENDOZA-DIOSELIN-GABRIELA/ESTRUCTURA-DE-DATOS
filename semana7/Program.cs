using System;
using System.Collections.Generic;

class Program
{
    static void TowersOfHanoi(int n, Stack<int> source, Stack<int> target, Stack<int> auxiliary, string sourceName, string targetName, string auxiliaryName)
    {
        if (n == 1)
        {
            int disk = source.Pop();
            target.Push(disk);
            Console.WriteLine($"Mover disco {disk} de {sourceName} a {targetName}");
            return;
        }

        TowersOfHanoi(n - 1, source, auxiliary, target, sourceName, auxiliaryName, targetName);
        int movedDisk = source.Pop();
        target.Push(movedDisk);
        Console.WriteLine($"Mover disco {movedDisk} de {sourceName} a {targetName}");
        TowersOfHanoi(n - 1, auxiliary, target, source, auxiliaryName, targetName, sourceName);
    }

    static void Main()
    {
        // Número de discos
        int n = 3;

        // Creación de las pilas
        Stack<int> source = new Stack<int>();
        Stack<int> target = new Stack<int>();
        Stack<int> auxiliary = new Stack<int>();

        // Inicialización de la pila origen con los discos
        for (int i = n; i >= 1; i--)
        {
            source.Push(i);
        }

        Console.WriteLine("Resolviendo Torres de Hanoi con 3 pilas:");
        TowersOfHanoi(n, source, target, auxiliary, "Origen", "Destino", "Auxiliar");

        Console.WriteLine("\nDiscos en la pila destino:");
        while (target.Count > 0)
        {
            Console.WriteLine(target.Pop());
        }
    }
}
