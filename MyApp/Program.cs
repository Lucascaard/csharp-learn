using ClassLibrary.Models;
using ClassLibrary.Interfaces;

CalculadoraComum calc = new();

List<int> list = new();

list.Add(calc.Somar(2,2));
list.Add(calc.Multiplicar(2,2));
list.Add(calc.Subtrair(2,2));
list.Add(calc.Dividir(2,2));

foreach(int result in list)
{
    Console.WriteLine(result);
}