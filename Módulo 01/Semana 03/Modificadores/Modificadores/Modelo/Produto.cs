namespace Modificadores.Modelo
{
    public class Produto
    {
        public string Nome;
        protected string Cor;
        private double Peso, Preco;

        public Produto(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
        }

        public Produto()
        {
        }

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto.");
        }

        protected void Vender()
        {
            Console.WriteLine("Vendendo produto, acessando método da classe produto.");
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando produto, método da classe produto");
        }

        protected void AlterarArtibutosPrivados(double peso, double preco)
        {
            Peso = peso;
            Console.WriteLine($"Variável peso do escopo da classe: {peso}");
            Preco = preco;
            Console.WriteLine($"Variável preço do escopo da classe: {preco}");
        }

        protected internal void teste()
        {
            Console.WriteLine("Acessado!");
        }
    }
}
