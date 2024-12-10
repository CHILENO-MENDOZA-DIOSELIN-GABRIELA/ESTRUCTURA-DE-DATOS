/*
    UNIVERSIDAD ESTATAL AMAZÓNICA
    Nombre: Chileno Mendoza Dioselin Gabriela
    Docente: Ortega Tenezaca Delfin Bernabe
    Tema: App de cálculo de áreas y perímetros
*/
using System;

namespace FigurasGeometricas
{
    // Clase Circulo
    public class Circulo
    {
        private double radio; // Atributo encapsulado que almacena el radio del círculo.

        // Constructor: inicializa el radio del círculo.
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es un método que devuelve un valor de tipo double.
        // Se utiliza para calcular el área de un círculo usando la fórmula: π * radio^2.
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // CalcularPerimetro es un método que devuelve un valor de tipo double.
        // Se utiliza para calcular el perímetro del círculo usando la fórmula: 2 * π * radio.
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo
    public class Rectangulo
    {
        private double largo; // Atributo encapsulado que almacena el largo del rectángulo.
        private double ancho; // Atributo encapsulado que almacena el ancho del rectángulo.

        // Constructor: inicializa el largo y el ancho del rectángulo.
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        // CalcularArea es un método que devuelve un valor de tipo double.
        // Se utiliza para calcular el área de un rectángulo usando la fórmula: largo * ancho.
        public double CalcularArea()
        {
            return largo * ancho;
        }

        // CalcularPerimetro es un método que devuelve un valor de tipo double.
        // Se utiliza para calcular el perímetro del rectángulo usando la fórmula: 2 * (largo + ancho).
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    }

    // Clase principal Program
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos al usuario el radio del círculo.
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Creamos una instancia de la clase Circulo.
            Circulo circulo = new Circulo(radio);

            // Mostramos el área y el perímetro del círculo.
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro():F2}");

            // Solicitamos al usuario el largo y el ancho del rectángulo.
            Console.Write("\nIngrese el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());

            // Creamos una instancia de la clase Rectangulo.
            Rectangulo rectangulo = new Rectangulo(largo, ancho);

            // Mostramos el área y el perímetro del rectángulo.
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro():F2}");
        }
    }
}
