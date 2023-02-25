namespace AulasSemana04.Classes
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Semestre { get; set; }
    }
    public override void Descrever()
    {
        Console.WriteLine($"O aluno {Nome} cursa o {Semestre}º do curso {Curso}");
    }
}
