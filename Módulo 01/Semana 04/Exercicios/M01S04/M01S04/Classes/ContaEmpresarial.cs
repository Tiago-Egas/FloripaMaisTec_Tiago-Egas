using M01S04.Classes;
using M01S04.Classes.Enums;

namespace M01S04.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        /*
        * [M1S04] Ex 04
        * Criação dos atributos LimiteEmprestimo, TaxaJuros, PossuiEmprestimo, ValorUsado e CNPJ
        */
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; } = false;
        public decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
        {
            this.LimiteEmprestimo = limiteEmprestimo;
            this.TaxaJuros = taxaJuros;
            this.CNPJ = cnpj;

            if (Cliente.TipoPessoa != TipoPessoaEnum.JURIDICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo Jurídico!");
            }
        }

        /*
         * [M1S04] Ex 05
         * Criação dos métodos FazerEmprestimo() e PagarEmprestimo()
         */
        public void FazerEmprestimo(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor informado deve ser maior do que 0!");
                return;
            }

            if (PossuiEmprestimo)
            {
                Console.WriteLine("Você já possui um empréstimo!");
                return;
            }

            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("O valor é maior que seu limite de empréstimo disponível!");
                return;
            }

            PossuiEmprestimo = true;
            base.Depositar(valor);
            this.ValorUsado = valor;
            Console.WriteLine($"Empréstimo no valor de R$ {valor} realizado com sucesso!");
        }

        public void PagarEmprestimo()
        {
            decimal total = this.ValorUsado + (this.ValorUsado * this.TaxaJuros / 100);
            if (total > Saldo)
            {
                Console.WriteLine("Seu saldo é insuficiente para pagar a fatura!");
                return;
            }

            Sacar(total);
            PossuiEmprestimo = false;
            ValorUsado = 0;
            Console.WriteLine($"Empréstimo de {total} foi pago!");
        }

        /*
         * [M1S04] Ex 06
         * Criação de Override dos métodos Sacar() e Transferir()
         */
        public override void Sacar(decimal valor)
        {
            valor += 1;
            base.Sacar(valor);
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor += 0.50M;
            base.Transferir(conta, valor);
        }
        
    }
}
