namespace M01S04.Classes
{
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; } = 0;

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Cliente = cliente;
            this.Saldo = 0;
        }
        public ContaBancaria(int numero, int agencia, Cliente cliente, decimal saldo)
        {
            this.Numero = numero;
            this.Agencia = agencia;
            this.Cliente = cliente;
            this.Saldo = saldo;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Informe valor maior que 0!");
                return;
            }
            else if (valor > this.Saldo)
            {
                Console.WriteLine("O valor digitado é maior que o saldo atual!");
                return;
            }
            else
            {
                this.Saldo += valor;
            }
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor digitado precisa ser maior que 0!");
                return;
            }
            else
            {
                this.Saldo += valor;
                Console.WriteLine($"O valor de R$ {valor} foi depositado com sucesso!");
            }
            ExibirSaldo();
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor digitado ser maior que 0!");
                return;
            }

            if (valor > this.Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            this.Saldo += valor;
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta: R$ {this.Saldo}.");
        }
    }
}
