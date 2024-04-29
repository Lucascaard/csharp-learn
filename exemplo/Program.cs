using Models;

namespace main
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Pessoa lucas = new()
            {
                Nome = "lucas",
                Idade = 27
            };

            lucas.Apresentar();

        }
    }
}