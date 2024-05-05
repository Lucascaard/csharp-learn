using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Exercicios
{
    public class Exercicio1
    {
        public void Func1()
        {
         // EXE 1 
            Console.WriteLine("Insira o salario bruto: ");
            string input = Console.ReadLine();
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