using Banco;

Console.WriteLine("Inciciando sistema...\n\n");
List<ContaBancaria> contas = new();

bool operacao = true;
while (operacao)
{
    Console.WriteLine("Cadastre duas contas.\n\n");

    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Cadastrando {i + 1}ª conta.\n");
        Cadastro();
        Console.WriteLine();
    }

    Console.Write("Agora faremos a transferência.\n");
    Transferencia();
}

Console.Write("\n\nVolte Sempre!\n\n");

void Cadastro()
{
    Console.Write("Cadastrando conta...\n");
    Console.Write("Informe o nome do Títular: ");
    string nome = Console.ReadLine();
    Console.Write("Informe o tipo da conta.\n" +
                  "\t0 - CORRENTE\n" +
                  "\t1 - POUPANCA\n\nOpção: ");
    int cont = int.Parse(Console.ReadLine());
    contas.Add(new(nome, cont));
}

void Transferencia()
{
    Console.Write("Informe a sua conta: \n");
    int contRemt = int.Parse(Console.ReadLine());
    if (true)
    {
        // verificar se a conta existe na lista
    }
    Console.Write("Informe a conta de destino: \n");
    int contDest = int.Parse(Console.ReadLine());
    if (true)
    {
        // verificar se a conta existe na lista
    }
    Console.Write("Informe o valor a ser transferido: \n");
    decimal valor = decimal.Parse(Console.ReadLine());
    if (true)
    {
        // testar se o valor a ser transferido é menor ou igual
        // que o saldo da conta do remetente
    }

    
}