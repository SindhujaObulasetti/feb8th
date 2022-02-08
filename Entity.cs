using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //TASK1
    public class Entity 
    {

        public class Product
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public double Cost { get; set; }
            public int Quantity { get; set; }
            public string ProductSoldDate { get; set; }
            public string DisplayProductId(string productid)
            {
                ProductId = productid;
                return ProductId;

                
            }
            public string DisplayProductName(string productname)
            {
                ProductName= productname;
                return ProductName;
            }
            public string DisplayDescription(string description)
            {
                Description = description;
                return Description;
            }
            public string DisplayProductSoldDate(string solddate)
            {
                ProductSoldDate = solddate;
                return ProductSoldDate;
            }
            public double DisplayCost(double cost)
            {
                Cost= cost;
                return Cost;
            }
            public int DisplayQuantity(int quantity)
            {
                Quantity = quantity*(int)Cost;  
                return Quantity;
            }
            
        }
    }
}
