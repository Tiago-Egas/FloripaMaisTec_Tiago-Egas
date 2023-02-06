// See https://aka.ms/new-console-template for more information

Console.WriteLine("Olá, Mundo!");

int numeroInteiro = 10; // var inteiros
long numMaior = 109999L; // var inteiros maiores
float numeroQuebrado = 6.8f; // var reais
double numeroQuebradoMaior = 101.9999999; // var reais maiores
char letra = 'A'; // var com única letra
string texto = "A turma Estreito é a melhor."; // var com texto ou frase
bool varBool = false; // var booleana que aceita false ou true
DateTime data = DateTime.Now; // var com data atual, contendo data e hora completa
DateTime outraData = new DateTime(2023, 01, 31); // instância de DateTime com apenas a data informada no parâmetro
texto.ToUpper(); // converte texto para letras maiúsculas
Console.WriteLine("Frase com letras maiúsculas: " + texto.ToUpper());

string nomeCompleto; // var sem inicialização
Console.WriteLine("Digite o seu nome: "); // impressão de comando para usuário
nomeCompleto = Console.ReadLine(); // aguarda informação do usuário
Console.WriteLine("O seu nome é: " + nomeCompleto); // Saída de dados, concatenando texto com valor da variável
