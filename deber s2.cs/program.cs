/*
    UNIVERSIDAD ESTATAL AMAZÓNICA
    Nombre: Chileno Mendoza Dioselin Gabriela
    Docente: Ortega Tenezaca Delfin Bernabe
    Tema: App de cálculo de áreas y perímetros
*/

using System;

namespace FigurasGeometricas
{
    public class Circulo
    {
        private double radio;
        public Circulo(double radio) => this.radio = radio;
        public double CalcularArea() => Math.PI * Math.Pow(radio, 2);
        public double CalcularPerimetro() => 2 * Math.PI * radio;
    }

    public class Rectangulo
    {
        private double largo, ancho;
        public Rectangulo(double largo, double ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        public double CalcularArea() => largo * ancho;
        public double CalcularPerimetro() => 2 * (largo + ancho);
    }

    class Program
    {
        static void Main()
        {
            // Entrada y cálculo para el círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = LeerNumeroPositivo();
            Circulo circulo = new Circulo(radio);
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro():F2}");

            // Entrada y cálculo para el rectángulo
            Console.Write("\nIngrese el largo del rectángulo: ");
            double largo = LeerNumeroPositivo();
            Console.Write("Ingrese el ancho del rectángulo: ");
            double ancho = LeerNumeroPositivo();
            Rectangulo rectangulo = new Rectangulo(largo, ancho);
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro():F2}");
        }

        // Método auxiliar para validar que los números ingresados sean positivos
        static double LeerNumeroPositivo()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Entrada inválida. Por favor, ingrese un número positivo: ");
            }
            return numero;
        }
    }
}
