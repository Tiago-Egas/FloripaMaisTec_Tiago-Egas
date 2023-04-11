int x = 2;
int y = 0;

try
{
    Console.WriteLine($"x / y é igual a {x / y}.");
}
catch (DivideByZeroException exDivisaoPorZeroException)
{
    Console.WriteLine($"\n\nExplicação do erro de divisão por zero: {exDivisaoPorZeroException.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {exDivisaoPorZeroException.StackTrace}");
}
catch (ArithmeticException exErroAritmeticoException)
{
    Console.WriteLine($"\n\nExplicação do erro: {exErroAritmeticoException.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {exErroAritmeticoException.StackTrace}");
}
catch (Exception exErroGenericoException)
{
    Console.WriteLine($"\n\nExplicação do erro genérico: {exErroGenericoException.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {exErroGenericoException.StackTrace}");
}
finally
{
    
}