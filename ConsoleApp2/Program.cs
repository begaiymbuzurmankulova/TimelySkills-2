
using ConsoleApp2;
using ConsoleApp2.Common;
using ConsoleApp2.Models;

var product = new Product("Cruissan", 200, CategoriaEnum.Food);

Console.WriteLine( product );
Console.WriteLine( product.Name );

var warehouse = new Warehouse();
warehouse.AddProduct(product);
var order = new Order("Timur", "Bishkek");
order.AddProducts(product);
Console.WriteLine( order );