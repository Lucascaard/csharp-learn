namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Lista para armazenar os itens
            List<string> itens = [];

            for (int i = 1; i <= 3; i++)
            {
                itens.Add(Console.ReadLine());

            }

            // Exibe a lista de itens
            Console.WriteLine("Lista de itens:");
            foreach (string item in itens)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
