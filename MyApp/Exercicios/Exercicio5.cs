using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Exercicios
{
    public class Exercicio5
    {

        public void Func1()
        {
            // Lendo arquivos com caminho feliz
            string[] linhas = File.ReadAllLines("Arquivos/leitura-errada.txt");

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha.ToString());
            }
        }

        public void Func2()
        {
            // Lendo arquivo e lançando exception personalizada
            try
            {
                Func1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
            }
        }
    }
}