using Construtor;

// Formas de iniciar um contrutor

// Iniciando com os atributos de acordo com
// o que os construtores permitem
Pessoa pessoa1 = new Pessoa(nome: "Tiago",
                     idade: 32);
Console.WriteLine($"A pessoa 1 é: {pessoa1.Nome} " +
                  $"e idade: {pessoa1.Idade}.");

// cada atribuição será identificada de acordo
// com os dados passados no construtor
Pessoa pessoa2 = new Pessoa(nome: "Fernando",
                     idade: 21,
                     altura: 1.83f);
Console.WriteLine($"A pessoa 2 é: {pessoa2.Nome}, " +
                  $"idade: {pessoa2.Idade} " +
                  $"e altura {pessoa2.Altura}.");

Pessoa pessoa3 = new Pessoa(nome: "Guilherme");
Console.WriteLine($"A pessoa 3 é: {pessoa3.Nome}.");

Pessoa pessoa4 = new Pessoa(altura: 1.58f);
Console.WriteLine($"O altura da pessoa 4 é: {pessoa4.Altura}.");

Pessoa pessoa5 = new Pessoa()
{
    Idade = 20
};
Console.WriteLine($"A pessoa 5 tem as seguintes características:\n" +
                  $"Nome: {pessoa5.Nome},\n" +
                  $"Idade: {pessoa5.Idade},\n" +
                  $"Altura: {pessoa5.Altura}.");