using System;
using Excecoes;

/* try
{
    // Estudante estudante1 = null;
    // string nomeEstudante = estudante1.Nome1;
    
    Console.WriteLine("Digite uma palavra: ");
    string palavra = Console.ReadLine();
    
    Console.WriteLine(palavra);
}
catch (NullReferenceException exReferenciaNula)
{
    Console.WriteLine($"O erro é: {exReferenciaNula.Message}.");
} */

try // Tente
{
    // Código
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"O resultado de {numero} x 10 é: {numero * 10}.");
}
catch (FormatException ex) // Tratatamento especídfico
{
    Console.WriteLine($"\n\nErro específico capturado: {ex}.\n\nCausa do erro: {ex.Message}.\n\n");
}
catch (Exception ex) // Tratamento genérico
{
    // Código do tratamento do erro
    Console.WriteLine($"Erro capturado: {ex.Message}.\n\n");
}
finally // Finalmente
{
    // Código da "limpeza" final
    Console.WriteLine("Somente um números.\n\n");
}