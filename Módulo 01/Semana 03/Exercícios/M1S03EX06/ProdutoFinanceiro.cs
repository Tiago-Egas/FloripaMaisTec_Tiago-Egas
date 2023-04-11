using M1S03EX06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S03EX06
{
    internal class ProdutoFinanceiro : Produto
    {
        public void Acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.Nome = "NomeProd";
            PF1.Cor = "CorProd";
            Console.WriteLine($"Nome: {PF1.Nome}, Cor: {PF1.Cor}.");

            PF1.Vender();
            PF1.VerificarEstoque();
            PF1.AlteraAtributosPrivados(99, 100.0);
        }
    }
}
