namespace AulasSemana04.Classes
{
    internal class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public string Cargo { get; set; }

        public void ReceberAumento(decimal aumento)
        {
            Salario += aumento;
        }
    }
}
