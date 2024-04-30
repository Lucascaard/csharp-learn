namespace Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(DateTime data)
        {
            Console.WriteLine($"Olá meu nome é {Nome}! \nEu eu tenho {Idade} anos! \nData atual + 10 dias: {data.ToString("dd/MM/yyyy HH:mm")}");
        }
    }
}