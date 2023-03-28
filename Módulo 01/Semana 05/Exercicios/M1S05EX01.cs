using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios;

public class M1S05EX01
{
    Console.WriteLine("Iremos dividir um primeiro número pelo segundo.\n")
    Console.Write("Informe um número: ");
    decimal num1 = decimal.Parse(Console.ReadLine());
    Console.Write("Informe outro número: ");
    decimal num2 = decimal.Parse(Console.ReadLine());

    try
    {
        Console.WriteLine($"Resultado da divisão: { num1 / num2 }.")
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($Erro: "{ex.Message}.\nsegundo número não pode ser 0.");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}.\nNão informe letras ou símboos.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro encontrado: {ex.Message}");
    }
    finally
    {
        num1 = 0;
        num2 = 0;
    }
}
