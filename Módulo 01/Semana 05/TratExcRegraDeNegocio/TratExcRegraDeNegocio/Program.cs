using TratExcRegraDeNegocio;

Evento evento = new Evento();

evento.QtdeIngressosVendidos = 15;
evento.QtdeLugares = 12;

if (evento.QtdeLugares - evento.QtdeIngressosVendidos > 0)
{
    Console.WriteLine("Ingresso validado!");
    evento.IngressoVendido();
}
else
{
    throw new IngressoExc("Não existem mais lugares para o evento!!");
}
