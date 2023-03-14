// Aula sobre Programação Orientada a Objetos (POO)

// Principais características deste tipo de paradigma: 
// Reusabilidade, extensabilidade, simplicidade e manutenibilidade.

/* Pilares POO:
 *      Encapsulamento: 
 *          técnica utilizada para esconder ou expor atributos das classes.
 *      Herança: 
 *          princípio que compartilha os atributos e os métodos das 
 *          classes para a reutilização de código.
 *      Polimorfismo: 
 *          utilizada com a Herança no caso de criar uma classe que
 *          terá os métodos da superclasse com seus próprios comportamentos.
 *      Abstração: 
 *          remove a necessidade de ter os detalhes dos métodos da 
 *          super-classe e passando isto para o comportamento da classe
 *          que irá implementar este comportamento.
 */

// Como informar uma classe: 
// por convenção deve informar a classe iniciada com letra maiúscula

/* No lugar de informar a classe dentro do programa principal, 
 * podemos criar namespaces para organizar as classes em diretórios
 * separados e importar o namespace com o "using".
 */

using POO.Classes;

// Instância do objeto, utilizando nova forma de instanciamento do Visual Studio
Carros Carro1 = new Carros()
{
    // criando novo objeto a partir da classe mãe
    cor = "Vinho",
    modelo = "Ka",
    marca = "Ford"
};

Console.WriteLine($"Atributos de {Carro1}: ");
Console.WriteLine($"Cor: {Carro1.cor}.");
Console.WriteLine($"Modelo: {Carro1.modelo}.");
Console.WriteLine($"Marca: {Carro1.marca}.");