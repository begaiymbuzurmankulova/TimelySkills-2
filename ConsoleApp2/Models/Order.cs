using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Order
    {
        public string Customer { get; set; }
        public string Address { get; set; }
        
        public List<Product> Products { get; set; }

        public Order(string customer, string address)
        {
            Customer = customer;
            Address = address;
            Products = new List<Product>();
        }

        public void AddProducts(params Product[] products)
        {
            Products.AddRange(products);
        }

        public override string ToString() 
        {
            var result = new StringBuilder();
            result.Append($"Client Name : {Customer} \n Address : {Address} \n Products : \n");
            foreach (var product in Products) {
                result.Append(product.ToString());
                result.Append("\n");
            }
            return result.ToString();   
        }


    }
}
