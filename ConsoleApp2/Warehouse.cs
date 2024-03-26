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

    public void RemoveProduct(CategoriaEnum category, string name)
    {
        if (productsByCategory.ContainsKey(category))
        {
            var product = productsByCategory[category].FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                productsByCategory[category].Remove(product);
                Console.WriteLine("Product removed from the warehouse.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        else
        {
            Console.WriteLine("Category not found.");
        }
    }

    public void CheckProductAvailability(CategoriaEnum category, string name)
    {
        if (productsByCategory.ContainsKey(category) && productsByCategory[category].Any(p => p.Name == name))
        {
            Console.WriteLine("Product is available.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}
