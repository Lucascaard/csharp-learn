using ClassLibrary.Models;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            People lucas = new()
            {
                Nome = "Lucas Cardoso",
                Idade = 27,
                Altura = 1.80F,
                Cidade = "Curitiba"
            };

            lucas.Apresentar();
        }
    }
}