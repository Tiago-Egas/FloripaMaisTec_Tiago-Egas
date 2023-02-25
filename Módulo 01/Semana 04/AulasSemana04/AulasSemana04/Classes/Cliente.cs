namespace AulasSemana04.Classes
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, DateTime nascimento, Endereco endereco) : base(nome, nascimento, endereco)
        {
        }

        public override void Descrever()
        {
            Console.WriteLine($"O cliente {Nome} nasceu em {Nascimento}");
        }
    }
}
