namespace Banco
{
    public class ContaTipo
    {
        private ContaTipoENUM contaTipoENUM;

        public enum ContaTipoENUM
        {
            CORRENTE = 0,
            POUPANCA = 1
        }

        public void ContaCorrente() => contaTipoENUM = ContaTipoENUM.CORRENTE;
    }
}