using static Banco.ContaTipo;

namespace Banco
{
    public class ContaBancaria
    {
        private int _numero;
        private int _agencia;
        private string? _titular;
        private decimal _saldo = 0;
        private ContaTipoENUM _contaTipo;

        // Atributos com Gets and Sets
        /*
         * [M1S03] Ex 03
         * Alteração de visibilidade da classe ContaBancaria
         */
        private int Numero { get => _numero; set => _numero = value; }
        private int Agencia { get => _agencia; set => _agencia = value; }
        private string? Titular { get => _titular; set => _titular = value; }
        private decimal Saldo { get => _saldo; set => _saldo = value; }
        private ContaTipoENUM ContaTipo { get => _contaTipo; set => _contaTipo = value; }

        // Construtores
        /*
         * [M1S03] Ex 02
         * Criação de construtor da classe ContaBancaria
         */
        public ContaBancaria(int Numero, int Agencia, string? Titular, ContaTipoENUM ContaTipo)
        {
            this.Numero = Numero;
            this.Agencia = Agencia;
            this.Titular = Titular;
            this.ContaTipo = ContaTipo;
            Console.WriteLine($"Conta de {this.Titular.ToUpper()} criada com sucesso!\n");
        }

        /*
         * [M1S03] Ex 04
         * Criação de construtor secundário para a classe ContaBancaria
         */
        public ContaBancaria(string? Titular, int ContaTipo)
        {
            Random rnd = new();
            this.Titular = Titular;
            this.ContaTipo = (ContaTipoENUM)ContaTipo;
            this.Numero = rnd.Next(0000, 9999);
            this.Agencia = rnd.Next(0000, 9999);
            Console.WriteLine($"Conta de {this.Titular.ToUpper()} criada com sucesso!\n");
        }

        public ContaBancaria()
        {
        }

        // Métodos
        public void Depositar(decimal Valor)
        {
            bool depValid = true;
            while (depValid)
            {
                if (Valor > 0)
                {
                    this.Saldo += Valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("\nInforme valores maiores que R$ 0,00.\n");
                }
            }
        }

        public void Sacar(decimal Valor)
        {
            bool sacValid = true;
            while (sacValid)
            {
                if (Valor > 0 && this.Saldo >= Valor)
                {
                    this.Saldo -= Valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("\nErro na operação!\n");
                    if (Valor <= 0)
                    {
                        Console.WriteLine("Valor de saque inválido!\n");
                    }
                    if (this.Saldo < Valor)
                    {
                        Console.WriteLine("Saldo insuficiente!\n");
                        ExibirSaldoAtual();
                    }
                    
                }
            }
        }

        public void ExibirSaldoAtual()
        {
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo}");
        }

        public void ExibirDados()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome do Títular: {this.Titular}.");
            Console.WriteLine($"Número da Conta: {this.Numero}.");
            Console.WriteLine($"Agência: {this.Agencia}.");
            Console.WriteLine($"Tipo de conta: {this.ContaTipo}.");
            Console.WriteLine($"Saldo Atual: R$ {this.Saldo}.");
            Console.WriteLine();
        }

        /*
         * [M1S03] Ex 05
         * Criação de método para fazer transferência na classe ContaBancaria
         */
        public void Transferir(int Remetente, int Destinatario, decimal Valor)
        {
            // TODO
            // Receber os dados das contas e fazer transferêcia do remetente
            // para o destinatário e informar os _saldos resultantes das duas contas
        }
    }
}