namespace M01S04.Classes
{
    public class Cliente
    {
        public string nome { get; private set; }
        public DateTime nascimento { get; private set; }
        public string profissao { get; private set; }
        public EstadoCivilEnum estadoCivil { get; private set; }
        public TipoPessoaEnum tipoPessoa { get; private set; }
    }
}
