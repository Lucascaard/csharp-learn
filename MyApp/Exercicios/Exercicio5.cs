
namespace MyApp.Exercicios
{
    public class Exercicio5
    {
        public void Func1()
        {
            // Lendo arquivos com caminho feliz
            string[] linhas = File.ReadAllLines("Arquivos/leitura-errada.txt");

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha.ToString());
            }
        }

        public void Func2()
        {
            // Lendo arquivo e lançando exception personalizada
            try
            {
                Func1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
            }
        }

        public void Func3()
        {
            // Lançando exceptions especificas
            try
            {
                Func1();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Falha de arquivo não encontrado: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Falha de diretorio não encontrado: " + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Falha de arquivo não suportado" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha generica de exception: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Este bloco será executado independente de Try e Catch, serve para por exemplo ao final de uma consulta no banco de dados, finalizar a conexão");
            }
        }

        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("METODO 1: Capturando a exceção: " + ex.Message);
            }
        }

        public void Metodo2()
        {
            throw new Exception("METODO 2: Lançando a exceção para quem chamar esse metodo");
        }
    }
}