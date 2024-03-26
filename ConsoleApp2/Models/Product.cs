using ConsoleApp2.Common;

namespace ConsoleApp2.Models
{
    public class Product
    {
        public CategoriaEnum CategoriaType { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }

        public Product  (string name, decimal price, CategoriaEnum categoria) {
            Name = name;
            Price = price;
            CategoriaType = categoria;
            CreatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $" Name : {Name} \n Price : {Price} som \n Category : {CategoriaType.ToString()}";
        }


    }
}
