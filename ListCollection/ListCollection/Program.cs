using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class ProductsDetails
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product
            {
                ProductName = "spreadsheet",
                ProductPrice = 450
            };
            Product pro2 = new Product
           {
               ProductName = "soap",
               ProductPrice = 35
           };

            Product pro3 = new Product()
            {
                ProductName = "pecil",
                ProductPrice = 15
            };
            Product pro4 = new Product()
            {
                ProductName = "pen",
                ProductPrice = 50
            };
            Product pro5 = new Product()
            {
                ProductName = "toothpaste",
                ProductPrice = 45
            };

            List<Product> lst = new List<Product>();
            lst.Add(pro1);
            lst.Add(pro2);
            lst.Add(pro3);
            lst.Add(pro4);
            lst.Add(pro5);

            foreach (var pd in lst)
            {
                Console.WriteLine("ProductName= {0}, ProductPrice= {1}", pd.ProductName, pd.ProductPrice);
            }
            Console.ReadKey();
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}

       



