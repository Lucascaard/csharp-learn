using Models;

namespace main
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Pessoa lucas = new()
            {
                Nome = "Lucas Cardoso",
                Idade = 27
            };

            DateTime dateTime = DateTime.Now.AddDays(10);

            //lucas.Apresentar(dateTime);

            // Tamanhos dos tipos primitivos em bytes
            Console.WriteLine("Tamanhos dos tipos primitivos em bytes:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("double: " + sizeof(double) + " bytes \t (Mínimo: " + double.MinValue + ", Máximo: " + double.MaxValue + ")");
            Console.WriteLine("long: " + sizeof(long) + " bytes \t (Mínimo: " + long.MinValue + ", Máximo: " + long.MaxValue + ")");
            Console.WriteLine("decimal: " + sizeof(decimal) + " bytes \t (Mínimo: " + decimal.MinValue + ", Máximo: " + decimal.MaxValue + ")");
            Console.WriteLine("float: " + sizeof(float) + " bytes \t (Mínimo: " + float.MinValue + ", Máximo: " + float.MaxValue + ")");
            Console.WriteLine("ulong: " + sizeof(ulong) + " bytes \t (Mínimo: 0, Máximo: " + ulong.MaxValue + ")");
            Console.WriteLine("int: " + sizeof(int) + " bytes \t (Mínimo: " + int.MinValue + ", Máximo: " + int.MaxValue + ")");
            Console.WriteLine("uint: " + sizeof(uint) + " bytes \t (Mínimo: 0, Máximo: " + uint.MaxValue + ")");
            Console.WriteLine("char: " + sizeof(char) + " bytes \t (Mínimo: '\\0', Máximo: '\\uffff')");
            Console.WriteLine("ushort: " + sizeof(ushort) + " bytes \t (Mínimo: 0, Máximo: " + ushort.MaxValue + ")");
            Console.WriteLine("short: " + sizeof(short) + " bytes \t (Mínimo: " + short.MinValue + ", Máximo: " + short.MaxValue + ")");
            Console.WriteLine("byte: " + sizeof(byte) + " byte \t (Mínimo: 0, Máximo: " + byte.MaxValue + ")");
            Console.WriteLine("sbyte: " + sizeof(sbyte) + " byte \t (Mínimo: " + sbyte.MinValue + ", Máximo: " + sbyte.MaxValue + ")");
            Console.WriteLine("bool: " + sizeof(bool) + " byte \t (Mínimo: False, Máximo: True)");
            // teste

        }
    }
}