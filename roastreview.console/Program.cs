

using roastreview.data;

foreach (var item in StockManager.GetStocks().ToArray())
{
    Console.WriteLine($"{item.Id} {item.Name} {item.Rating}");
}


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
