using M1S03EX06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Produto produto1 = new Produto();

produto1.Nome = "Calculadora";
produto1.VerificarEstoque();
Console.WriteLine(value: $"O nome do produto é {produto1.Nome}");

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
classeFilha.Nome = "Produto Financeiro";
classeFilha.VerificarEstoque();
classeFilha.Acesso();