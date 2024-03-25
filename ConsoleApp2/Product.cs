namespace ConsoleApp2;

using System;

public class Product
{
    public string Category { get; set; }
    public string Name { get; set; }
    public DateTime ReceiptDate { get; set; }
    public decimal Price { get; set; }

    public Product(string category, string name, DateTime receiptDate, decimal price)
    {
        Category = category;
        Name = name;
        ReceiptDate = receiptDate;
        Price = price;
    }
}
