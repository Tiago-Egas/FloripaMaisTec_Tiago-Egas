try
{
    string s = null;

    if (s.Length > 0)
    {
        Console.WriteLine($"Quantidade de caracteres: {s.Length}.");
    }
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro capturado: {ex}, Faça isso para sair deste erro!\n");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro genérico: {ex}.\n");
}
