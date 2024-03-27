using System.ComponentModel;

namespace ConsoleApp2;

using ConsoleApp2.Common;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class Warehouse
{
    private Dictionary<CategoriaEnum, List<Product>> productsByCategory = new Dictionary<CategoriaEnum, List<Product>>();

    public void AddProduct(Product product)
    {
        if (!productsByCategory.ContainsKey(product.CategoriaType))
        {
            productsByCategory[product.CategoriaType] = new List<Product>();
        }

        var products = productsByCategory[product.CategoriaType];
        if (products.Count >= 500)
        {
            Console.WriteLine("Shelf for category " + product.CategoriaType + " is full.");
        }
        else
        {
            products.Add(product);
            Console.WriteLine("Product added to the warehouse.");
        }
    }
    
    

    public void RemoveProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product), "Product cannot be null.");
        
        if (productsByCategory.ContainsKey(product.CategoriaType))
        {
            Console.WriteLine("Products are available.");
        }
        
        if (!productsByCategory[product.CategoriaType].Remove(product))
        {
            Console.WriteLine("Product is not found");
        }
        else
        {
            Console.WriteLine("Product is removed successfully");
        }
        

    }


    public void CheckProductAvailability(CategoriaEnum category, int count)
    {
        if (productsByCategory.ContainsKey(category) && productsByCategory[category].Count < count)
        {
            Console.WriteLine("Products are available.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}
