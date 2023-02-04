// Aula sobre: 
// Arrays,
// Listas.

// Primeira forma de declarar um array: 
// informar o tipo, com colchetes (colchetes determina uma coleção de dados do tipo informado)
// o nome do array
// recebendo
// instância nova string com o total de índices
// por seguinte informar os valores informando o índice manualmente
Console.WriteLine("\n####################################\n");

string[] nomes1 = new string[4];

nomes1[0] = "Maria";
nomes1[1] = "João";
nomes1[2] = "Kátia";
nomes1[3] = "Fernando";

Console.WriteLine("Primeira lista de nomes: ");
for (int i = 0; i < nomes1.Count(); i++)
{
    Console.WriteLine(nomes1[i]);
}

// Segunda forma de declara um array:
// informar o tipo, com colchetes
// o nome do array
// recebendo
// valores dentro de chaves, seguindo as regras de cada tipo
string[] nomes2 = { "Maria", "João", "Paulo", "Antonio" };

Console.WriteLine("\n####################################\n");

Console.WriteLine("Segunda lista de nomes: ");
foreach (string item in nomes2)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n####################################\n");

// Método de manipulações de arrays: 
Console.WriteLine($"Menor valor contido no array (nomes1): {nomes1.Min()}");
// mínimo de acordo com o valor do array
Console.WriteLine($"Maior valor contido no array (nomes2): {nomes2.Max()}");
// máximo de acordo com o valor do array

Console.WriteLine("\n####################################\n");

// Arrays bidimensionais: 
int[,] array2d = new int[2,2];

array2d[0,0] = 1;
array2d[0,1] = 2;
array2d[1,0] = 3;
array2d[1,1] = 4;

/* Representação do exemplo
 * de array bidimensinal: 
    [1] [2]
    [3] [4]
 */

Console.WriteLine("\n####################################\n");

/*02.Faça um algoritmo que receba e preencha um array com quatro modelos de carros. 
 * Em seguida receba e preencha um array com o consumo referente a cada modelo de carro. 
 * Após isso mostre: 
 * o nome de cada modelo e 
 * quantos litros de combustível seria necessário para percorrer 100km. 
 * o modelo de carro mais econômico.
*/

// Listas
List<string> nomes = new List<string>();

nomes.Add("Maria");
nomes.Add("João");
nomes.Remove("Maria");
nomes.Add("Fernando");
nomes.Add("Antonio");
nomes.Add("Luiza");
