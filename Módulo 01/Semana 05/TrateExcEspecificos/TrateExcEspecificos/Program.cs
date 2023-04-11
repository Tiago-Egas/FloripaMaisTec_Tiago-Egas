try
{
    string texto = "0";

    int numero = Convert.ToInt32(texto);

    int resultado = 100 / numero;

    Console.Write($"O resultado de 100 divido por {numero} é: {resultado}.");
}
catch (DivideByZeroException exDivididoPorZero)
{
    Console.WriteLine(
        $"Erro: {exDivididoPorZero.Message}.\nO número informado não pode ser zero, informe outro número.\n"
    );
}
catch (FormatException exFormatoIncorreto)
{
    Console.WriteLine(
        $"Erro: {exFormatoIncorreto.Message}.\nO formato de número informado é inválido. Informe outro valor.\n"
    );
}
catch (Exception exErroGenerico)
{
    Console.WriteLine(exErroGenerico.Message);
}
