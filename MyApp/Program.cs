using ClassLibrary.Models;
using MyApp.Exercicios;


People p1 = new("Lucas Cardoso", 27);
IFTernario ife = new();

Console.WriteLine(ife.Func1(32));


(string nome, int idade) = p1;