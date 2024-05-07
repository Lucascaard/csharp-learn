namespace ClassLibrary.Models
{
    public class People
    {
        public People()
        {

        }

        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }
        /*Serve pra isso:
            People p1 = new("Lucas Cardoso", 27);
            (string nome, int idade) = p1;
        */
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();
            set => _nome = string.IsNullOrEmpty(value) ? throw new ArgumentException("O nome não pode ser vazio") : value;
        }

        private int _idade;
        public int Idade
        {
            get => _idade;
            set => _idade = int.IsNegative(value) ? throw new ArgumentException("Idade não pode ser negativa!") : value;
        }
        public People(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos!");
        }
    }
}