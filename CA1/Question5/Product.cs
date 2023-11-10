using System;
namespace Question5
{
	public class Product
	{
		//properties
		public string ProductName { get; set; }
        public int ProductID { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

		//constructor
        public Product(string productName, int productID, double price, string category)
		{
			ProductName = productName;
			ProductID = productID;
			Price = price;
			Category = category;
		}

		//methods
		public void PrintProductDetails()
		{
			Console.WriteLine($"Product name     = " + ProductName);
            Console.WriteLine($"Product ID       = " + ProductID);
            Console.WriteLine($"Product Price    = " + Price);
            Console.WriteLine($"Product Category = " + Category);
        }

        public void ApplyDiscount(double percentage)
        {
            double discount;
            discount = Price * (percentage / 100);
            Price = Price - discount;

        }

        public override string ToString()
		{
			return $"{ProductName} {ProductID} {Price} {Category}";
        }
    }
}

