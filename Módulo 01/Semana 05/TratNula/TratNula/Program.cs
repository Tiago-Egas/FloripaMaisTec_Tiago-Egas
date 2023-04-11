try
{
    string frase = null;

    if (frase.Length > 0)
    {
        Console.WriteLine($"Quantidade de caracteres: {frase.Length}.");
    }
}
catch (NullReferenceException exValorNulo)
{
    Console.WriteLine($"Erro capturado: {exValorNulo}, Faça isso para sair deste erro!\n");
}
catch (Exception exErroGenerico)
{
    Console.WriteLine($"Erro genérico: {exErroGenerico.Message}.\n");
}
