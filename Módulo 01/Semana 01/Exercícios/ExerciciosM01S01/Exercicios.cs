/* [M01S02] Ex 1 - Buscador de números primos
 * Faça um programa que receba do usuário dez números inteiros, 
 * e ao final, exiba os números primos e suas respectivas posições.
*/
Console.WriteLine("\n############################################################" +
                    "\nQuestão 1: Buscador de números primos;\n");

int[] primos = new int[10];

for (int i = 0; i < primos.Length; i++)
{
    Console.Write($"Informe um número {i + 1}: ");
    primos[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < primos.Length; i++)
{
    int cont = 1;
    for (int j = 1; j < primos[i]; j++)
    {
        if (primos[i] % j == 0)
        {
            cont++;
        }
    }
    if (cont == 2)
    {
        Console.WriteLine($"É número {primos[i]} primo e está na posição {cont}");
    }
}

/*[M01S02] Ex 2 - Organizador de lista de frutas
 * Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens.
 * Organize as frutas em ordem alfabética e exiba a lista.
 */
Console.WriteLine("\n############################################################" +
                    "\nQuestão 2: Organizador de lista de frutas;\n");

List<string> frutas = new();

Console.WriteLine("Informe até 15 frutas: ");

bool contFrut = true;

while (contFrut)
{
    if (frutas.Count >= 15)
    {
        contFrut = false;
    }
    else
    {
        Console.Write("Nome da fruta: ");
        frutas.Add(item: Console.ReadLine());

        Console.Write("Quer continuar (S|N)? ");
        string respFruta = Console.ReadLine();

        switch (respFruta.ToUpper())
        {
            case "NAO":
            case "N":
                contFrut = false;
                break;
            case "SIM":
            case "S":
                continue;
            default:
                Console.WriteLine("Opção inválida!");
                continue;
        }
    }
}

frutas.Sort();

Console.WriteLine("\n\nExibição das frutas informadas em ordem alfabética: ");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

/* [M01S02] Ex 3 - Separador de números ímpares e pares
 * Faça um programa que receba do usuário dez números inteiros e execute os seguintes passos:
 * a) Separe em duas listas sendo um somente números ímpares e o outro números pares.
 * b) Coloque os números de cada lista em ordem crescente.
 * c) Exiba como resultado o número de elementos em cada lista e a soma dos valores de cada um. 
 * Ex: “A lista de números ímpares possui 5 números e a soma deles é igual a 47”
*/
Console.WriteLine("\n############################################################" +
                    "\nQuestão 3: Separador de números ímpares e pares;\n");

int[] numeros = new int[10];
List<int> pares = new();
List<int> impares = new();

Console.WriteLine($"Informe {numeros.Length} números: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"{i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        pares.Add(numeros[i]);
    }
    else
    {
        impares.Add(numeros[i]);
    }
}

pares.Sort();
impares.Sort();

Console.WriteLine($"\nDos números informados, " +
                  $"{pares.Count} são pares e " +
                  $"{impares.Count} são ímpares.");

Console.WriteLine("\n");
Console.WriteLine($"Soma de {pares.Count} números pares: {pares.Sum()}.\n" +
                  $"Soma de {impares.Count} números ímpares: {impares.Sum()}.");

/* [M01S02] Ex 4 - Cálculo de média de aprovação
 * Faça um programa que receba o nome e média final de cinco alunos. Armazene em um array
 * ou list os nomes e em outra as médias. Ao final, exiba o nome de cada aluno e a mensagem
 * “APROVADO” para quem tiver média acima de 6 e “REPROVADO” para quem não.
*/
Console.WriteLine("\n############################################################" +
                "\nQuestão 4: Cálculo de média de aprovação;\n");

int turma = 2;
List<string> alunos = new();
List<float> media = new();

Console.WriteLine($"Informe o nome e média de {turma} alunos");

for (int i = 0; i < turma; i++)
{
    Console.Write($"{i + 1}º aluno: ");
    alunos.Add(Console.ReadLine());
    Console.Write($"Média do {i + 1}º aluno: ");
    media.Add(float.Parse(Console.ReadLine()));
}

Console.WriteLine("");
Console.WriteLine("Estado de aprovação da turma: ");
for (int i = 0; i < turma; i++)
{
    if (media[i] >= 6)
    {
        Console.WriteLine($"{i + 1}º Aluno: {alunos[i].ToUpper()}. " +
                        $"Média: {media[i]}." +
                        "\t\tAPROVADO!");
    }
    else
    {
        Console.WriteLine($"{i + 1}º Aluno: {alunos[i].ToUpper()}. " +
                        $"Média: {media[i]}." +
                        "\t\tREPROVADO!");
    }
}

/*[M01S02] Ex 5 - Sequência de Fibonacci
 * Faça um algoritmo que receba um número inteiro que será a quantidade de números
 * calculados pela sequência de Fibonacci. Em seguida, exiba a sequência no terminal.
 * Ex: Se receber o número 7, você irá exibir a sequência “1 2 3 5 8 13 21” 
 * que contém ao todo 7 números.
*/
Console.WriteLine("\n############################################################" +
                    "\nQuestão 5: Sequência de Fibonacci;\n");

int fibbo, soma, atual = 1, ant = 0;

Console.Write("Informe o limite de iterações Fibonacci: ");
fibbo = int.Parse(Console.ReadLine());

for (int i = 0; i < fibbo; i++)
{
    soma = atual + ant;
    Console.WriteLine($"{i + 1}º número: {soma}");
    ant = atual;
    atual = soma;
}

Console.WriteLine("\n############################################################\n");