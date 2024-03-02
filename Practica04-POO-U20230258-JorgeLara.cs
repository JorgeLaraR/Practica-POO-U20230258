using System.Drawing;

namespace Practica3_u20230258
{
    public abstract class FiguraGeometrica
    {
        public abstract string Forma { get; }

        public abstract int CalcularAreaTriangulo { get; }

    }

    public sealed class Triangulo : FiguraGeometrica
    {
        public override string Forma => "Triangulo";
        public override int CalcularAreaTriangulo => 10; 
        public double CalcularArea()
        {
            return 20;
        }
        public string Lados { get; set; }
        public Triangulo(string lados)
        {
            Lados = lados;
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo("Ecuación...");
            triangulo.CalcularArea();
            Console.WriteLine($"Base por altura entre 2 tomando en cuenta que la altura es 10cm y la base 4: {triangulo.CalcularArea()} cm");
            Console.WriteLine($"Lados: {triangulo.Lados}");
        }
    }
}
