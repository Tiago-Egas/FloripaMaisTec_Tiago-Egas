// Aula sobre:
// operações comparativas,
// relacionais, 
// estruturas de repetição

/* 1. Operadores matemáticos: 
    +   (soma)
    -   (subtração)
    *   (multiplicação)
    /   (divisão)
    %   (resto da divisão inteira)
*/

/* 2. Operadores de atribuição e comparação: 
    =   (atribuição)
    ==  (comparação)
    >   (comparação maior)
    <   (comparação menor)
    >=  (comparação maior que ou igual)
    <=  (comparação menor que ou igual)
    !=  (comparação diferente de)
*/

/* 3. Precedência de operações: 
    ()  Parênteses
    **  Expoentes
    *,/ Multiplicações e divisões (da esquerda para a direita)
    +,- Somas e subtrações (da esquer para a direita)
*/

/* 4. Condicionais: 
    Condicional Simples: IF
    Condicional Composta: IF ELSE
    Condicional Múltipla: SWITCH-CASE
*/

/* 5. Estruturas de repetição: 
    Repetição validando ao ínicio: WHILE
    Repetição validando ao final: DO ... WHILE
    Repetição com validação e auto incremento: FOR
    Repetição com auto incremento a partir de uma coleção
*/

/* 
 * Exemplo de condicional simples e composta
 */

int num1 = 0;
int num2 = 0;

Console.WriteLine("Informe o primero número: ");
Console.ReadLine();
Console.WriteLine("Informe o segundo número: ");
Console.ReadLine();

if (num1 % 2 == 0)
{
    // se a condição for verdadeira
    // esta parte do código será executada
    Console.WriteLine("O número é par.");
}
else if (num1 % 2 > 0)
{
    // caso a condição anterior for falsa
    // então esta parte do código será executada
    Console.WriteLine("O número é ímpar.");
}
else
{
    // caso nenhuma das anteriores for verdadeira
    // então está será parte a ser executada

    Console.WriteLine("Condição ELSE executada");
}

/* 
 * Exemplo de condicional de múltipla escolha
 * com estrutura de repetição WHILE
 */

Console.WriteLine("No Brasil temos 5 regiões.\n" +
    "Informe uma das regiões corretamente: ");
bool continuar = true;

while (continuar)
{
    string regiao = Console.ReadLine();
    regiao = regiao.ToUpper();
    switch (regiao)
    {
        case "SUL":
            Console.WriteLine("Resposta certa!");
            break;
        case "NORTE":
            Console.WriteLine("Resposta certa!");
            break;
        case "CENTRO-OESTE":
            Console.WriteLine("Resposta certa!");
            break;
        case "NORDESTE":
            Console.WriteLine("Resposta certa!");
            break;
        case "SUDESTE":
            Console.WriteLine("Resposta certa!");
            break;
        default:
            Console.WriteLine("Opção incorreta!");
            break;
    }

    Console.WriteLine("Você deseja continuar? ");
    string resposta = Console.ReadLine();

    if (resposta.ToUpper() != "SIM")
    {
        continuar = false;
    }

    if (resposta.ToUpper() == "SIM")
    {
        Console.WriteLine("Digite outra região: ");
    }
}

/* 
 * Exemplo de repetição com FOR
 */

for (int i = 0; i < 5; i++)
{
    Console.Write("Item: " + i + "; ");
}