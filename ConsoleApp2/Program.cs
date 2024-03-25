// See https://aka.ms/new-console-template for more information
//this is the order class

using System;
using System.Collections.Generic;
using ConsoleApp2;

public class Program
{
    public List<Product> Products { get; set; }
    public string RecipientName { get; set; }
    public string RecipientAddress { get; set; }

    public Program()
    {
        Products = new List<Product>();
        RecipientName = "";
        RecipientAddress = "";
    }

    public Program(List<Product> products, string recipientName, string recipientAddress)
    {
        Products = products;
        RecipientName = recipientName;
        RecipientAddress = recipientAddress;
    }

    public void SetRecipientInformationFromConsole()
    {
        Console.WriteLine("Enter recipient's name:");
        RecipientName = Console.ReadLine();

        Console.WriteLine("Enter recipient's address:");
        RecipientAddress = Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        Program order = new Program();
        order.SetRecipientInformationFromConsole();

    }
}
