using System.Globalization;

namespace EXERCICIO_003
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo() 
        {

        }

        internal double Area() 
        {
            return  Largura * Altura;
        }

        internal double Perimetro() 
        {
            return 2 * (Largura + Altura);
        }

        internal double Diagonal() 
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

    }
}