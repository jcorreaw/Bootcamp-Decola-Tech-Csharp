//IF

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida!");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe, Não tempos a quantidade desejada em estoque.");
}

//Switch Case

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal!");
        break;
    default:
        Console.WriteLine("Não é uma vogal!");
        break;
        
}