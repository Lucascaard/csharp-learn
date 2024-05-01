/* Minha solução

using System;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o salario bruto: ");
            string? input = Console.ReadLine();
            double salarioBruto = double.Parse(input);

            Console.WriteLine("Insira os beneficios: ");
            input = Console.ReadLine();
            double beneficio = double.Parse(input);

            double aliquota;
            double salarioLiquido;

            if (salarioBruto <= 1100)
            {  // 5%
                aliquota = salarioBruto * 0.05;
            }
            else if (salarioBruto <= 2500)
            {
                // 10%
                aliquota = salarioBruto * 0.10;
            }
            else
            {
                // 15%
                aliquota = salarioBruto * 0.15;
            }
            salarioLiquido = salarioBruto - aliquota + beneficio;
            Console.WriteLine("Salario liquido é: " + salarioLiquido);

        }
    }
}
*/

using System;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
