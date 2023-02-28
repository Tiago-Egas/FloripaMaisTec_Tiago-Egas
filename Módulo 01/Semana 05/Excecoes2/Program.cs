int x = 2;
int y = 0;

try
{
    Console.WriteLine($"x / y é igual a {x / y}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"\n\nExplicação do erro de divisão por zero: {ex.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {ex.StackTrace}");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"\n\nExplicação do erro: {ex.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {ex.StackTrace}");
}
catch (Exception ex)
{
    Console.WriteLine($"\n\nExplicação do erro genérico: {ex.Message}");
    Console.WriteLine($"\n\nStackTrace do erro: {ex.StackTrace}");
}
finally
{
    
}