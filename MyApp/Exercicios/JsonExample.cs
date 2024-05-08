using ClassLibrary.Models;
using MyApp.Exercicios;
using Newtonsoft.Json;
namespace MyApp.Exercicios
{
    public class JsonExample
    {
        public void Func()
        {
            DateTime dataVenda = DateTime.Now;
            List<Venda> vendas = [];
            Venda v1 = new(1, "Cardernos", 29.99M, dataVenda);
            Venda v2 = new(2, "Canetas", 9.99M, dataVenda);
            Venda v3 = new(3, "Marca Texto", 7.99M, dataVenda);

            vendas.Add(v1);
            vendas.Add(v2);
            vendas.Add(v3);

            string serializacao = JsonConvert.SerializeObject(vendas, Formatting.Indented);

            File.WriteAllText("Arquivos/vendas.json", serializacao);
            Console.WriteLine(serializacao);
        }
    }
}