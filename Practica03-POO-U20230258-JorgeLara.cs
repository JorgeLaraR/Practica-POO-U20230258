namespace PraticaTres_u20230258
{
    public interface IPoderesFuerza
    {
        void SonidoSable();
        void Agilidad(int espacio);
    }

    public abstract class Jedi
    {
        public abstract string Lado { get; }

        public void MostrarJedi()
        {
            Console.WriteLine($"El lado de la fuerza que sigue es: {Lado}");
        }

        public abstract void Meditar();

        public abstract void EstiloPelea(string forma);

        public void Midiclorianos(int cantidad)
        {
            Console.WriteLine($"El {Lado} registra un número de {cantidad} Midiclorianos en los sensibles a la fuerza.");
        }
    }

    class Humano : Jedi, IPoderesFuerza
    {
        public override string Lado => "Lado Luminoso";

        public override void EstiloPelea(string forma)
        {
            Console.WriteLine($"El Jedi pelea con la forma {forma}");
        }

        public override void Meditar()
        {
            Console.WriteLine("El Jedi está meditando.");
        }

        void IPoderesFuerza.SonidoSable()
        {
            throw new NotImplementedException();
        }

        void IPoderesFuerza.Agilidad(int espacio)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Humano persona = new Humano();

            persona.MostrarJedi();
            persona.Meditar();
            persona.EstiloPelea("Forma IV");
            persona.Midiclorianos(120);
        }
    }
}
