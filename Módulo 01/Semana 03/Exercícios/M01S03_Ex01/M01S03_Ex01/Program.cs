using M01S03_Ex01;

Produto produto1 = new("Xícara",
                       25.00,
                       8);

Produto produto2 = new();

Console.WriteLine($"O produto 1 tem nome: {produto1.Nome}, " +
                  $"preço: {produto1.Preco} " +
                  $"e quantidade: {produto1.Quantidade}.");
Console.WriteLine($"O produto 2 tem nome: {produto2.Nome}, " +
                  $"preço: {produto2.Preco} " +
                  $"e quantidade: {produto2.Quantidade}.");
// teste