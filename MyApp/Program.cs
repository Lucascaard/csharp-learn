using ClassLibrary.Models;
using MyApp.Exercicios;
using Newtonsoft.Json;

Venda v1 = new(1,"Cardernos",29.99M);

string serializacao = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializacao);
Console.WriteLine(serializacao);

