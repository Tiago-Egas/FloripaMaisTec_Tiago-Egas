using static Banco.ContaTipo;

namespace Banco
{
    public class ContaBancaria
    {
        // Atributos com Gets and Sets
        /*
         * [M1S03] Ex 03
         * Alteração de visibilidade da classe ContaBancaria
         */
        private int Numero { get; set; }
        private int Agencia { get; set; }
        private string? Titular { get; set; }
        private decimal Saldo { get; set; } = 0;
        private ContaTipoENUM ContaTipo { get; set; }

        // Construtores
        /*
         * [M1S03] Ex 02
         * Criação de construtor da classe ContaBancaria
         */
        public ContaBancaria(int numero, int agencia, string? titular, ContaTipoENUM contaTipo)
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
        public ContaBancaria(string? titular, int contaTipo)
        {
            Random rnd = new();
            this.Titular = titular;
            this.ContaTipo = (ContaTipoENUM)contaTipo;
            this.Numero = rnd.Next(0000, 9999);
            this.Agencia = rnd.Next(0000, 9999);
            Console.WriteLine($"Conta de {this.Titular.ToUpper()} criada com sucesso!\n");
        }

        public ContaBancaria()
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
                if (valor > 0 && Saldo > valor)
                {
                    this.Saldo -= valor;
                    ExibirSaldoAtual();
                }
                else
                {
                    Console.WriteLine("\nValor de saque inválido!\n");
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
        public void Transferir(int conta, int valor)
        {
            // TODO
        }
    }
}