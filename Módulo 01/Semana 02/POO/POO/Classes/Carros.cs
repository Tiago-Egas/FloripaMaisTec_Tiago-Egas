// Processo de criação de classes e métodos

// informar a classe como um namespace que 
// irá permitir importar em outros documentos
namespace POO.Classes
{
    /* 'internal' irá permitir que apenas os documentos
     * contidos na solução poderão enxergar a classe
     * e seus atributos 
    */
    internal class Carros
    {
        /* 'public' será o escopo do atributo
         * '?' será para evitar que o atributo seja nulo
         * */
        public string? modelo;
        public string? cor;
        public string? marca;
    }
}
