namespace Construtor
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public float Altura;

        // C# já identifica corretamente o construtor
        // a ser utilizado em cada situação independente
        // se o construtor mais acima possui atributos
        // obrigatórios
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa(string nome, int idade, float altura)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
        }

        public Pessoa(float altura)
        {
            this.Altura = altura;
        }

        // abaixo um exemplo de construtor vazio
        // permitindo informar apenas os valores
        // que forem relevantes
        public Pessoa() { }
    }
}
