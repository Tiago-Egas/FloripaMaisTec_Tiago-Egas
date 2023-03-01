using System;

FileInfo arquivo = null;

try
{
    System.Console.Write("Digite o nome do arquivo que você vai criar: ");

    string nomeArquivo = Console.ReadLine();

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto dentro do arquivo.");
    }
}
catch (ArgumentException ex)
{
    System.Console.WriteLine($"Tratando o erro de forma específica: {ex.Message}.\n");
}
catch (Exception ex)
{
    System.Console.WriteLine($"Ocorreu um erro: {ex.Message}.\n");
}
finally
{
    System.Console.WriteLine($"Encerrando programa...\n");
    arquivo = null;
    // Console.Clear();
}
