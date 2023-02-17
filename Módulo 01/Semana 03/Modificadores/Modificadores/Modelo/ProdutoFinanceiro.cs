namespace Modificadores.Modelo
{
    internal class ProdutoFinanceiro : Produto
    {
        protected void Acessar()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();
            PF1.Nome = "Produto dentro classe produto finaceiro";
            PF1.Cor = "Verde";
            Console.WriteLine($"Nome: {PF1.Nome}. Cor: {PF1.Cor}");
            PF1.Vender();
            PF1.VerificarEstoque();
            PF1.AlterarArtibutosPrivados(99, 100.0);
        }
    }
}