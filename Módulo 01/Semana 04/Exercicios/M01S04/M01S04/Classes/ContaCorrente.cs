using M01S04.Classes;
using M01S04.Classes.Enums;

namespace M01S04.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (Cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Física!");
            }
        }

        /*
         * [M1S04] Ex 06
         * Criação de Override dos métodos Sacar() e Transferir()
         */
        public override void Sacar(decimal valor)
        {
            valor += 0.50M;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}
