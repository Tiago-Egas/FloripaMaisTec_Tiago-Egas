namespace M01S03_Ex01
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public Produto()
        {
            this.Nome = "Sem nome";
            this.Preco = 0;
            this.Quantidade = 0;
        }
    }
}
