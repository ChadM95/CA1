namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        //instantiate product objects
        Product P1 = new Product("Rip Curl Dawn Patrol",1,320,"Wetsuit");
        Product P2 = new Product("Pyzel Ghost",2,600,"Surfboard") ;

        //Use display method
        P1.PrintProductDetails();
        Console.WriteLine(); //for spacing
        P2.PrintProductDetails();

        //Use apply discount method
        P1.ApplyDiscount(10);
        P2.ApplyDiscount(10);

        Console.WriteLine();

        //Use display method to check discount has been applied

        P1.PrintProductDetails();
        Console.WriteLine();
        P2.PrintProductDetails();

        Console.ReadLine();
    }
}

