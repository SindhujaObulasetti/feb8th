using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 2
            string ProductId;
            string ProductName;
            string Description;
            string ProductSoldDate;
            double Cost;
            int Quantity;
            Entity.Product product1=new Entity.Product();
            Console.WriteLine("Enter ProductId: ");
            ProductId=Console.ReadLine();

            Console.WriteLine("Enter ProductName: ");
            ProductName=Console.ReadLine();

            Console.WriteLine("Enter Description: ");
            Description=Console.ReadLine();

            Console.WriteLine("Enter ProductSoldDate: ");
            ProductSoldDate=Console.ReadLine();

            Console.WriteLine("Enter Cost: ");
            Cost=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity");
            Quantity=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            
            Console.WriteLine("ProductId: "+ product1.DisplayProductId(ProductId));
            Console.WriteLine("Product Name: "+ product1.DisplayProductName(ProductName));
            Console.WriteLine("Product Description: " + product1.DisplayDescription(Description));
            Console.WriteLine("Product Sold Date: " + product1.DisplayProductSoldDate(ProductSoldDate));
            Console.WriteLine("Product Cost: " + product1.DisplayCost(Cost));
            Console.WriteLine("Product Quantity: " + product1.DisplayQuantity(Quantity));


        }
    }
}
