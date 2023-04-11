using System;

Console.WriteLine("Iremos dividir o primeiro número pelo segundo.");
Console.Write("Informe um número: ");
decimal num1 = decimal.Parse(Console.ReadLine());
Console.Write("Informe outro número: ");
decimal num2 = decimal.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"Resultado da divisão: { num1 / num2 }.");
}
catch (DivideByZeroException exDivididoPorZero)
{
    Console.WriteLine($"Erro: {exDivididoPorZero.Message}.\nSegundo número não pode ser 0.");
}
catch (FormatException exFormatoIncorreto)
{
    Console.WriteLine($"Erro: {exFormatoIncorreto.Message}.\nNão informe letras ou símbolos.");
}
catch (Exception exErroGenerico)
{
    Console.WriteLine($"Erro encontrado: {exErroGenerico.Message}");
}
finally
{
    num1 = 0;
    num2 = 0;
}