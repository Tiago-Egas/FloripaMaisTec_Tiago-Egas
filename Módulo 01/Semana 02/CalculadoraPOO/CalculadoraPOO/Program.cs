using CalculadoraPOO.Classes;

Calculos calculadora = new Calculos();

int resultado;

resultado = calculadora.Somar(10, 10);
Console.WriteLine($"Resultado da soma: {resultado}.");

resultado = calculadora.Subtrair(10, 10);
Console.WriteLine($"Resultado da subtração: {resultado}.");

resultado = calculadora.Multiplicar(10, 10);
Console.WriteLine($"Resultado da multiplicação: {resultado}.");

resultado = calculadora.Dividir(10, 10);
Console.WriteLine($"Resultado da divisão: {resultado}.");