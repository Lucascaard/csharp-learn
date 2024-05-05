
namespace ClassLibrary.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public string Professor { get; set; }
        public List<People> Alunos { get; set; } = new List<People>();

        public void AdicionarAluno(People aluno)
        {
            Alunos.Add(aluno);
        }

        public void ListarAlunos()
        {
            for (var i = 0; i < Alunos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Alunos[i].Nome.ToUpper()}");
            }
        }

    }
}