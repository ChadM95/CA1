using System;
namespace Question5
{
	public class Product
	{
		//properties
		public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

		//constructor
        public Product(string productName, int productID, int price, string category)
		{
			productName = ProductName;
			productID = ProductID;
			price = Price;
			category = Category;
		}

		//method
		public void PrintProductDetails()
		{
			Console.WriteLine($"Product name     = {ProductName}");
            Console.WriteLine($"Product ID       = {ProductID}");
            Console.WriteLine($"Product Price    = {Price}");
            Console.WriteLine($"Product Category = {Category}");
        }
	}
}

