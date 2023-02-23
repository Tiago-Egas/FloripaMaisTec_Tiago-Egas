namespace AulasSemana04.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Endereco EnderecoCompleto { get; set; }

        public Pessoa(string nome, DateTime nascimento, Endereco enderecoCompleto)
        {
            Nome = nome;
            Nascimento = nascimento;
            EnderecoCompleto = enderecoCompleto;
        }

        public Pessoa(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa()
        {
        }
    }
}
