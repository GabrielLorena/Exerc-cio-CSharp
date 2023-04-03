
using System;

namespace EXERCICIO_004
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Imposto: ");
            funcionario.Imposto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine(funcionario);
            Console.WriteLine(" ");

            Console.Write("Digite a porcentagem para aumentar: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            funcionario.AumentarSalario(valor);

            Console.Write("Dados atualizados: " + funcionario);
        }
    }
}

