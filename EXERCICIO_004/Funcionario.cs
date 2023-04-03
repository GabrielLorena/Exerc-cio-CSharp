using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCICIO_004
{
    public class Funcionario
    {
        public string? Nome; 
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double valor) {

            valor = SalarioBruto += SalarioBruto * 0.1;
        }

        public double SalarioLiquido()
        {   
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return "Funcionário: " + Nome + ", " + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}