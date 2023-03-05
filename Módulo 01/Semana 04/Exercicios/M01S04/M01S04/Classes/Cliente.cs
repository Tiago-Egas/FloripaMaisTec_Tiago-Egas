using M01S04.Classes.Enums;

namespace M01S04.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public EstadoCivilENUM EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

        public Cliente(string nome, string profissao, DateTime nascimento, EstadoCivilENUM estadocivil, TipoPessoaEnum tipoPessoa)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Profissao = profissao;
            this.EstadoCivil = estadocivil;
            this.TipoPessoa = tipoPessoa;
        }
    }
}
