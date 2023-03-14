using Banco_Pt2.Classes.Enum;

namespace Banco_Pt2.Classes
{
    public class ContaBancaria_pt2
    {
        private int _numero;
        private int _agencia;
        private string? _titular;
        private decimal _saldo = 0;
        private contaTipoENUM_pt2 _contaTipo;

        // Atributos com Gets and Sets
        /*
         * [M1S03] Ex 03
         * Alteração de visibilidade da classe ContaBancaria
         */
        private int Numero { get => _numero; set => _numero = value; }
        private int Agencia { get => _agencia; set => _agencia = value; }
        private string? Titular { get => _titular; set => _titular = value; }
        private decimal Saldo { get => _saldo; set => _saldo = value; }
        private contaTipoENUM_pt2 ContaTipo { get => _contaTipo; set => _contaTipo = value; }

        // Construtores
        /*
         * [M1S03] Ex 02
         * Criação de construtor da classe ContaBancaria
         */
        public ContaBancaria_pt2(int numero, int agencia, string? titular, contaTipoENUM_pt2 contaTipo)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Titular = titular;
            this.ContaTipo = contaTipo;
            Console.WriteLine($"Conta de {this.Titular.ToUpper()} criada com sucesso!\n");
        }

        /*
         * [M1S03] Ex 04
         * Criação de construtor secundário para a classe ContaBancaria
         */
        public ContaBancaria_pt2(string? titular, int contaTipo)
        {
            Random rnd = new Random();
            this.Titular = titular;
            this.ContaTipo = (contaTipoENUM_pt2)contaTipo;
            this.Numero = rnd.Next(0000, 9999);
            this.Agencia = rnd.Next(0000, 9999);
            Console.WriteLine($"Conta de {this.Titular.ToUpper()} criada com sucesso!\n");
        }

        public ContaBancaria_pt2()
        {
        }

        // Métodos
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
                    Console.WriteLine("\nInforme valores maiores que R$ 0,00.\n");
                }
            }
        }

        public void Sacar(decimal valor)
        {
            bool sacValid = true;
            while (sacValid)
            {
                if (valor > 0 && this.Saldo >= valor)
                {
                    this.Saldo -= valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("\nErro na operação!\n");
                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor de saque inválido!\n");
                    }
                    if (this.Saldo < valor)
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
            Console.WriteLine($"Nome do Titular: {this.Titular}.");
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
        public void Transferir(int remetente, int destinatario, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de transferêcia inválido!\n");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            this.Saldo = this.Saldo + valor;

            Depositar(valor);

            Console.WriteLine($"O valor foi transferido com sucesso!");
            Console.WriteLine($"Seu novo saldo é: R$ {this.Saldo}.");
        }
    }
}