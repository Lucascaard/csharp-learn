namespace ClassLibrary.Models
{
    public abstract class Conta
    {
        public Conta(string tipo)
        {
            Tipo = tipo;
        }
        protected double Saldo { get; set; }

        protected string Tipo { get; set; }

        public abstract void Creditar(double valor);

        public void VerSaldo()
        {
            Console.WriteLine("SALDO: " + Saldo);
        }
    }
}