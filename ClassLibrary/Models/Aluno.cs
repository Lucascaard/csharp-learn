namespace ClassLibrary.Models
{
    public class Aluno : People
    {
        public double  Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o {Nome} e minha nota é {Nota}");
        }
    }
}