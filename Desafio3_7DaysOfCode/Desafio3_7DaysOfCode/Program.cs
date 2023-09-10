using Desafio3_7DaysOfCode;

var historicoEstoque = new Estoque();

var produto1 = new Produto() { codigoBarra = 001, nomeP = "Feijao", precoP = 3.00F, quantidadeP = 3 };
var produto2 = new Produto() { codigoBarra = 002, nomeP = "Abóbora", precoP = 5.50F, quantidadeP = 7 };
var produto3 = new Produto() { codigoBarra = 003, nomeP = "Carne", precoP = 20.50F, quantidadeP = 9 };
var produto4 = new Produto() { codigoBarra = 004, nomeP = "Arroz", precoP = 7.00F, quantidadeP = 5 };
var produto5 = new Produto() { codigoBarra = 005, nomeP = "Batata", precoP = 5.00F, quantidadeP = 6 };

historicoEstoque.CadastrarProduto(produto1);
historicoEstoque.CadastrarProduto(produto2);
historicoEstoque.CadastrarProduto(produto3);
historicoEstoque.CadastrarProduto(produto4);
historicoEstoque.CadastrarProduto(produto5);

historicoEstoque.MostrarProdutos();

historicoEstoque.AtualizarQuantidade(004, 3);

historicoEstoque.MostrarProdutos();

historicoEstoque.DeletarProduto(002);

historicoEstoque.MostrarProdutos();
