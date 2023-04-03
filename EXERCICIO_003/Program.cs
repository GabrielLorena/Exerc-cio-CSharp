using System.Globalization;

namespace EXERCICIO_003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Calculo do Retângulo");
            Console.WriteLine(" ");

            Console.Write("Digite a largura: ");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Digite a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");

            Console.Write("PERÍMETRO =  " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");

            Console.Write("DIAGONAL =  " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}