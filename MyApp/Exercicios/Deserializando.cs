using Newtonsoft.Json;
using ClassLibrary.Models;

namespace MyApp.Exercicios
{
    public class Deserializando
    {
        public void Func()
        {
            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
            List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda venda in listaVendas)
            {
                Console.WriteLine(venda.ToString());
            }
        }
    }
}