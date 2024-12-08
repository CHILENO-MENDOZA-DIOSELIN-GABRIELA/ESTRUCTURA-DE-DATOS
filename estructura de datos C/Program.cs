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
        private double radio; // Atributo encapsulado

        // Constructor
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo
    public class Rectangulo
    {
        private double largo;  // Atributo encapsulado
        private double ancho;  // Atributo encapsulado

        // Constructor
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return largo * ancho;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (largo + ancho);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Uso de la clase Circulo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Circulo circulo = new Circulo(radio);
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro():F2}");

            // Uso de la clase Rectangulo
            Console.Write("\nIngrese el largo del rectángulo: ");
            double largo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = Convert.ToDouble(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(largo, ancho);
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro():F2}");
        }
    }
}
