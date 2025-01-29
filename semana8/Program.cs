using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Queue<string> cola = new Queue<string>();
        int totalAsientos = 30;

        // Simulación de llegada de personas
        string[] personas = { "Ana", "Carlos", "Beatriz", "Daniel", "Elena", "Fernando", "Gabriela", "Hugo", "Isabel", "Javier", "Karla", "Luis", "Marta", "Nicolas", "Olga", "Pablo", "Queta", "Raul", "Sandra", "Tomas", "Ursula", "Victor", "Wendy", "Ximena", "Yolanda", "Zoe", "Alejandro", "Berta", "Cesar", "Diana" };
        
        foreach (var persona in personas) {
            if (cola.Count < totalAsientos) {
                cola.Enqueue(persona);
            }
        }
        
        // Mostrar asignaciones
        Console.WriteLine("Lista de ocupantes en la atracción:");
        int asiento = 1;
        while (cola.Count > 0) {
            Console.WriteLine($"Asiento {asiento}: {cola.Dequeue()}");
            asiento++;
        }
    }
}
