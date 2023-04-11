using System.Security.AccessControl;
using System;

FileInfo arquivo = null;

try
{
    Console.Write("Digite o nome do arquivo que você vai criar: ");
    string nomeArquivo = Console.ReadLine();
    arquivo = new FileInfo(nomeArquivo);

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo.");
    }
}
catch (ArgumentException exArgumentoIncoreto)
{
    Console.WriteLine($"Tratando o erro de forma específica: {exArgumentoIncoreto.Message}.\n");
}
catch (Exception exErroGenerico)
{
    Console.WriteLine($"Ocorreu um erro: {exErroGenerico.Message}.\n");
}
finally
{
    Console.WriteLine($"Encerrando programa...\n");
    arquivo = null;
    // Console.Clear();
}