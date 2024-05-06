using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Exercicios
{
    public class MetodoComTupla
    {
        public (bool Sucesso, string[], int QtdeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, Array.Empty<string>(), 0);
            }
        }

        /*exemplo do uso no Program
        MetodoComTupla mtdo = new();

        var (sucesso, linhasArquivo, qtdeLinhas ) = mtdo.LerArquivo("Arquivos/leitura.txt");
        Console.WriteLine(sucesso);
        foreach(var linhas in linhasArquivo)
        {
            Console.WriteLine(linhas.ToString());
        }
        Console.WriteLine($"Quantidade de linhas: {qtdeLinhas}");
        */
    }
}