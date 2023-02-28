try // Tente
{
    // Código
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {numero} x 10 é: {numero * 10}.");
}
catch (FormatException ex)
{
    Console.WriteLine($"\n\nErro específico capturado: {ex}.\n\nCausa do erro: {ex.Message}.\n\n");
}

catch (Exception ex) // Trate
{
    // Código do tratamento do erro
    Console.WriteLine($"Erro capturado: {ex.Message}.\n\n");
}
finally // Finalmente
{
    // Código da "limpeza" final
    Console.WriteLine("Somente um números.\n\n");
}