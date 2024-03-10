namespace PracticaCincoU20230258
{
    using System;

    public interface IFormas
    {
        double CalcularArea();
        double CalcularPerimetro();
    }

    public struct Rectangulo : IFormas
    {
        public double Ancho;
        public double Largo;

        public Rectangulo(double ancho, double largo)
        {
            Ancho = ancho;
            Largo = largo;
        }

        public double CalcularArea()
        {
            return Ancho * Largo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Ancho + Largo);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Ingresar el largo de un rectángulo > > > ");
            double largo;
            while (!double.TryParse(Console.ReadLine(), out largo) || largo <= 0)
            {
                Console.Write("Valor inválido. Ingrese un número positivo para el largo de un rectángulo: ");
            }

            Console.Write("Ingresar el ancho del rectángulo > > > ");
            double ancho;
            while (!double.TryParse(Console.ReadLine(), out ancho) || ancho <= 0)
            {
                Console.Write("Valor inválido. Ingrese un número positivo para el ancho de un rectángulo: ");
            }

            Rectangulo rectangulo = new Rectangulo(largo, ancho);

            Console.WriteLine($"Área de un rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro de un rectángulo: {rectangulo.CalcularPerimetro()}");
        }
    }
}
