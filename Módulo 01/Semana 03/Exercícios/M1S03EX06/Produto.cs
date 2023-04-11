using M1S03EX06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace M1S03EX06
{
    internal class Produto
    {
        private string? Nome;
        protected string? Cor;
        private double Peso;
        private double Preco;

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void Vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void AlteraAtributosPrivados(double peso2, double preco)
        {
            this.Peso = peso2;
            this.Preco = preco;
            Console.WriteLine($"Variável peso de escopo da classe: {this.Peso}");
        }
    }
}
