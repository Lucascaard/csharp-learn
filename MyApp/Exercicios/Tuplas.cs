namespace MyApp.Exercicios
{
    public class Tuplas
    {
        public void Func1()
        {
            //1º Jeito de declarar Tuplas
            (string nome, string cidade, int cep, int idade) dados = ("Lucas Cardoso", "Curitiba", 81480195, 27);

            //2º Jeito
            #pragma warning disable CS0219 // A variável é atribuída, mas seu valor nunca é usado
            ValueTuple<string, string, int, int> dados2 = ("Lucas Cardoso", "Curitiba", 81480195, 27);

            //3º Jeito
            #pragma warning restore CS0219 // A variável é atribuída, mas seu valor nunca é usado
            var dados3 = Tuple.Create("Lucas Cardoso", "Curitiba", 81480195, 27);

            Console.WriteLine($"Olá meu nome é {dados.nome}, tenho {dados.idade}! Moro em {dados.cidade} no CEP: {dados.cep}");
        }
    }
}