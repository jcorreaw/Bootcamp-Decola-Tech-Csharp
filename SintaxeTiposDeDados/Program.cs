using SintaxeTiposDeDados.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "João";
pessoa1.Idade = 22;
pessoa1.Apresentar();

string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura);
Console.WriteLine("Valor da variavel preço: " + preco);
Console.WriteLine("Valor da variavel condição: " + condicao);

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));