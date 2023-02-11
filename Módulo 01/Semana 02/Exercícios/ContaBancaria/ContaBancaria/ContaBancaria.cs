using static Banco.ContaTipo;

namespace Banco
{
    public class ContaBancaria
    {
        /*
         * [M1S02] Ex 03
         */
        private int Numero;
        private int Agencia;
        private string? Titular;
        private decimal Saldo = 0;
        private ContaTipoENUM ContaTipo;

        // Gets and Sets
        public int numero
        {
            get => this.Numero;
            set => this.Numero = value;
        }
        public int agencia
        {
            get => this.Agencia;
            set => this.Agencia = value;
        }
        public string? titular
        {
            get => this.Titular;
            set => this.Titular = value;
        }
        public decimal saldo
        {
            get => this.Saldo;
            set => this.Saldo = value;
        }
        public ContaTipoENUM contaTipo
        {
            get => this.ContaTipo;
            set => this.ContaTipo = value;
        }

        // Métodos
        public void CadastrarConta()
        {
            Console.Write("Informe o número da conta: ");
            this.numero = int.Parse(Console.ReadLine());

            Console.Write("Informe a agência: ");
            this.Agencia = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do Titular: ");
            this.Titular = Console.ReadLine();

            Console.Write("Informe o saldo atual: ");
            this.Saldo = decimal.Parse(Console.ReadLine());

            Console.Write("Tipo de conta.\n0 - CORRENTE\n1 - POUPANCA\n\nOpção: ");
            int opcaoConta = int.Parse(Console.ReadLine());
            switch (opcaoConta)
            {
                case 0:
                    this.contaTipo = ContaTipoENUM.CORRENTE;
                    break;
                case 1:
                    this.ContaTipo = ContaTipoENUM.POUPANCA;
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.\n\n");
                    break;
            }
        }

        /*
         * [M1S02] Ex 04
         */
        public void Depositar(decimal valor)
        {
            bool depValid = true;
            while (depValid)
            {
                if (valor > 0)
                {
                    this.Saldo += valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("Informe valores maiores que R$ 0,00.");
                }
            }
        }

        /*
         * [M1S02] Ex 05
         */
        public void Sacar(decimal valor)
        {
            bool sacValid = true;
            while (sacValid)
            {
                if (valor > 0 && Saldo > valor)
                {
                    this.Saldo -= valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("Valor de saque inválido.");
                }
            }
        }

        /*
         * [M1S02] Ex 06
         */
        public void ExibirSaldoAtual()
        {
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo}");
        }

        public void ExibirDados()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Exibindo dados da conta {this}");
            Console.WriteLine($"Nome do Títular: {this.titular}.");
            Console.WriteLine($"Número da Conta: {this.numero}.");
            Console.WriteLine($"Agência: {this.agencia}.");
            Console.WriteLine($"Tipo de conta: {this.contaTipo}.");
            Console.WriteLine($"Saldo Atual: R$ {this.saldo}.");
            Console.WriteLine("\n");
        }
    }
}
