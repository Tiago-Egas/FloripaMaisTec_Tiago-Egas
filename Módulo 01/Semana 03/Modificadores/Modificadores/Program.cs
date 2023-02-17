/* Modificadores de acesso e seus escopos: 
 * public: todo o projeto/aplicação vê a classe, métodos e atributos 
 * protected: apenas classes derivadas e filhas tem acessso
 * private: somente a própria classe acessa
 * internal: somente dentro do assembly tem acesso
*/

using Modificadores.Modelo;

// instanciando e acessando a classe
Produto produto1 = new();
produto1.Nome = "Calculadora";
produto1.VerificarEstoque();
Console.WriteLine($"O nome do produto 1 é: {produto1.Nome}");
produto1.VerificarEstoque();

Console.WriteLine("------- Abaixo será valores e ações de classes filhas -------");

// instanciando e acessando a subclasse
ProdutoFinanceiro classeFilha = new();
classeFilha.Nome = "Produto Financeiro";
classeFilha.VerificarEstoque();