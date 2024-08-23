// See https://aka.ms/new-console-template for more information
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
System.Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    System.Console.WriteLine("Venda realizada.");
}
else
{
    System.Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
