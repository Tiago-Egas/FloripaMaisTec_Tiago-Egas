namespace TratExcRegraDeNegocio
{
    public class Evento
    {
        public int QtdeLugares { get; set; }
        public int QtdeIngressosVendidos { get; set; }

        public Evento() { }

        public void IngressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!!");
        }
    }
}
