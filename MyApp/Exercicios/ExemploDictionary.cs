namespace MyApp.Exercicios
{
    public class ExemploDictionary
    {
        public void Func1()
        {
            Dictionary<int, string> estados = new Dictionary<int, string>();
            estados.Add(41, "Curitiba-PR");
            estados.Add(11, "São Paulo-SP");
            estados.Add(21, "Rio de Janeiro-RJ");

            foreach (var estado in estados)
            {
                Console.WriteLine(estado.ToString());
            }

            estados.Remove(21);
            Console.WriteLine("Removendo RJ e editando SP");
            estados[41] = "São Paulo Alterado";

            foreach (var estado in estados)
            {
                Console.WriteLine(estado.ToString());
            }

            //EXEMPLO DE COMO BUSCAR CHAVES NO DICTIONARY
            if (estados.ContainsKey(41))
            {
                Console.WriteLine("Chave 41 já existe");
            }
            else
            {
                Console.WriteLine("Chave 41 NÃO EXISTE");
            }

            //ACESSANDO O VALOR DA CHAVE
            Console.WriteLine(estados[41]);  // output é Curitiba-PR
        }
    }
}
