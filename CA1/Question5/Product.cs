using System;
namespace Question5
{
	public class Product
	{
		public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        public Product(string productName, int productID, int price, string category)
		{
			productName = ProductName;
			productID = ProductID;
			price = Price;
			category = Category;
		}
	}
}

