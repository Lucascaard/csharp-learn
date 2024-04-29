namespace Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public byte Teste { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}!\nEu eu tenho {Idade} anos!");
        }
    }
}