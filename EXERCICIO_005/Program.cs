

namespace EXERCICIO_005
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            aluno.Nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + aluno.CalculaNota());
            aluno.CalculaNota();

            Console.WriteLine("");

            aluno.Aprovacao();


        }
    }
}
