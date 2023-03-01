namespace TratExcRegraDeNegocio
{
    public class IngressoExc : Exception
    {
        public IngressoExc() { }

        public IngressoExc(string message)
            : base(message) { }

        public IngressoExc(string message, Exception causaException)
            : base(message, causaException) { }
    }
}
