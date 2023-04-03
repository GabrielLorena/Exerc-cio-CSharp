using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO_005
{
    public class Aluno
    {   
        public string? Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaMin = 60;
        public Boolean Aprovado = false;
        public double NotaFinal;


        public double CalculaNota() 
        {
            NotaFinal = Nota1 + Nota2 + Nota3;
            return NotaFinal;
        }

        public Boolean Aprovacao() 
        {
            if(NotaFinal < NotaMin ) {
                double falta = NotaMin - NotaFinal;
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + falta +  " PONTOS");
                Aprovado = false;
            } 
            else 
            {
                Console.WriteLine("APROVADO");
            }

            return Aprovado;
        }
            
    }
}