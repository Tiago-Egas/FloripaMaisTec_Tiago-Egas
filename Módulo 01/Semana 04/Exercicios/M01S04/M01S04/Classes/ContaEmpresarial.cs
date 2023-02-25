namespace M01S04.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal limiteEmprestimo { get; private set; }
        public decimal taxaJuros { get; private set; }
        public bool possuiEmprestimo { get; private set; } = false;
        public decimal valorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal saldo, decimal limiteEmprestimo, decimal taxaJuros, decimal valorUsado, string cnpj) : base(numero, agencia, cliente, saldo)
        {
            this.limiteEmprestimo = limiteEmprestimo;
            this.taxaJuros = taxaJuros;
            this.valorUsado = valorUsado;
            this.CNPJ = cnpj;
        }

        public void FazerEmprestimo()
        {
            /* 
             * a. realiza transação de empréstimo recebendo como parâmetro o valor do empréstimo;
             * b. o valor não pode ser maior que o definido no atributo;
             * c. o valor recebido deve ser adicionado ao saldo;
             * d. só é permitido um empréstimo por vez. para realizar um novo deve ser feito o 
             *      pagamento do anterior;
             */
        }

        public void PagarEmprestimo()
        {
            /* 
             * a. realiza o pagamento do valor pego por empréstimo adicionado a taxa de juros;
             * b. o empréstimo deve ser pago em valor integral;
             * c. o valor pago deve ser retirado do saldo;
             * d. a propriedade PossuiEmprestimo deve ser marcada com false;
             */
        }
    }
}
