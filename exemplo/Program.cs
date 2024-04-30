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

            double _double = double.MaxValue;
            long _long = long.MaxValue;
            float _float = float.MaxValue;
            int inteiro = int.MaxValue;
            ulong _ulong = ulong.MaxValue;
            uint _uint = uint.MaxValue;
            byte _byte = byte.MaxValue;

            long longo = Convert.ToInt32(inteiro);
            Console.WriteLine($"Max int: {inteiro} \nMax Double: {_double} \nMax float: {_float} ");
            Console.WriteLine($"Max long: {_long} \nMax byte: {_byte} \nMax uint: {_uint} \nMax ulong: {_ulong}");
        }
    }
}