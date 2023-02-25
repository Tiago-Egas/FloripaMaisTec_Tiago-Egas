using System.Drawing;

namespace M01S04.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; } = 0;

        public ContaBancaria(int numero, int agencia, Cliente cliente, decimal saldo)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Cliente = cliente;
            this.Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            // Sacar um valor;
            if (valor > 0 && this.Saldo >= valor)
            {
                this.Saldo -= valor;
                ExibirSaldo();
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
                    ExibirSaldo();
                }
            }
        }

        public void Depositar(decimal valor)
        {
            // deposita um valor;
            if (valor > 0)
            {
                this.Saldo += valor;
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("\nInforme valores maiores que R$ 0,00.\n");
            }
        }

        public void Transferir()
        {
            // transfere um valor;
        }

        public void ExibirSaldo()
        {
            // exibe uma mensagem com o saldo atual;
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo}");
        }
    }
}
