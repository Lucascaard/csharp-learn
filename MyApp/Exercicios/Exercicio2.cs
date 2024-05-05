using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Exercicios
{
    public class Exercicio2
    {

        public void Func1()
        {
            // EXE2 - Solução salario
            Console.WriteLine("Solução com Dictionary");
            Console.WriteLine();
            Console.WriteLine("Insira o salario bruto: ");
            if (!double.TryParse(Console.ReadLine(), out double salarioBruto))
            {
                Console.Error.WriteLine("A entrada para o salário bruto não é um número válido.");
                return;
            }

            Console.WriteLine("Insira os beneficios: ");
            if (!double.TryParse(Console.ReadLine(), out double beneficio))
            {
                Console.Error.WriteLine("A entrada para os benefícios não é um número válido.");
                return;
            }

            var taxRules = new Dictionary<double, double>
            {
                { 1100, 0.05 }, // 5% para salários até 1100
                { 2500, 0.10 }, // 10% para salários até 2500
                { double.MaxValue, 0.15 } // 15% para salários acima de 2500
            };

            double aliquota = 0;
            foreach (var rule in taxRules)
            {
                if (salarioBruto <= rule.Key)
                {
                    aliquota = salarioBruto * rule.Value;
                    break;
                }
            }

            double salarioLiquido = salarioBruto - aliquota + beneficio;
            Console.WriteLine("Salario liquido é: " + salarioLiquido);
        }
    }
}