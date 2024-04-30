namespace ClassLibrary.Models
{
    public class People
    {
        public string? Nome { get; set; }
        public byte Idade { get; set; }
        public float Altura { get; set; }
        public string? Cidade { get; set; }

        public People(string? nome, byte idade, float altura, string? cidade)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
            Cidade = cidade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Altura} de altura e {Idade} anos! \tMoro atualmente em {Cidade}");
        }
    }
}