using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Lista genérica ===");
        Lista listaGenerica = new Lista();

        listaGenerica.AgregarElemento(1);
        listaGenerica.AgregarElemento(2);
        listaGenerica.AgregarElemento(3);
        listaGenerica.AgregarElemento(2);
        listaGenerica.AgregarElemento(5);

        listaGenerica.MostrarElementos();
        listaGenerica.BuscarDato(2);
        listaGenerica.BuscarDato(4);

        Console.WriteLine("\n=== Lista enlazada ===");
        ListaEnlazada listaEnlazada = new ListaEnlazada();

        listaEnlazada.Agregar(10);
        listaEnlazada.Agregar(20);
        listaEnlazada.Agregar(30);
        listaEnlazada.Agregar(40);

        Console.WriteLine("Lista inicial:");
        listaEnlazada.Imprimir();

        Console.WriteLine($"El número de elementos en la lista es: {listaEnlazada.ContarElementos()}");

        Console.WriteLine("\nIngrese el valor que desea eliminar:");
        int valorEliminar = int.Parse(Console.ReadLine());
        listaEnlazada.Eliminar(valorEliminar);

        Console.WriteLine("\nLista después de la eliminación:");
        listaEnlazada.Imprimir();
        Console.WriteLine($"El número de elementos restantes en la lista es: {listaEnlazada.ContarElementos()}");
    }
}
