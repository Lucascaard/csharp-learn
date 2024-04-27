using System;

class Program
{
	public static void Main()
	{
		var pilha = new Acme.Collections.PilhaDePratos<string>();
		pilha.NovoPrato("1. azul"); // stack contains 1
		pilha.NovoPrato("2. Preto"); // stack contains 1, 10
		pilha.NovoPrato("3. Branco"); // stack contains 1, 10, 100
		Console.WriteLine("Retirando prato: " + pilha.RetiraPrato()); // stack contains 1, 10
		Console.WriteLine("Retirando prato: " + pilha.RetiraPrato()); // stack contains 1
		Console.WriteLine("Retirando prato: " + pilha.RetiraPrato()); // stack is empty
	}
}