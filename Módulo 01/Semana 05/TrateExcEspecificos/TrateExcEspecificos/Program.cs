try
{
    string texto = "0";

    int numero = Convert.ToInt32(texto);

    int resultado = 100 / numero;

    Console.Write($"O resultado de 100 divido por {numero} é: {resultado}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(
        $"Erro: {ex.Message}.\nO número informado não pode ser zero, informe outro número.\n"
    );
}
catch (FormatException ex)
{
    Console.WriteLine(
        $"Erro: {ex.Message}.\nO formato de número informado é inválido. Informe outro valor.\n"
    );
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
