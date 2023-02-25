namespace M01S04.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente, decimal saldo) : base(numero, agencia, cliente, saldo)
        {
            if (true)
            {
                // TODO: Cliente pode ser apenas tipoPessoa FISICA
            }

        }

        public override void Sacar()
        {
            /* 
             * a. Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,50 por cada saque;
             * b. Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,10 por cada saque;
             * c. Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 1,00 por cada saque;
             */
        }

        public override void Transferir()
        {
            /* 
             * a. Classe ContaCorrente - deve ser cobrada uma taxa de R$ 0,25 por cada transferência;
             * b. Classe ContaPoupanca - deve ser cobrada uma taxa de R$ 0,05 por cada transferência;
             * c. Classe ContaEmpresarial - deve ser cobrada uma taxa de R$ 0,50 por cada transferência;
             */
        }
    }
}
