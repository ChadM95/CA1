namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        //variables
        int basicSeatCost, bags10kg, bags20kg, meals, reservedSeats, totalCost;

        //input
        Console.Write("Please enter seat cost > ");
        basicSeatCost = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of 10kg bags > ");
        bags10kg = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of 20kg bags > ");
        bags20kg = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of on-board meals > ");
        meals = int.Parse(Console.ReadLine());

        Console.Write("Please enter number of reserved seats > ");
        reservedSeats = int.Parse(Console.ReadLine());

        //calculations
        totalCost = basicSeatCost + (bags10kg * 20) + (bags20kg * 30) + (meals * 10) + (reservedSeats * 5);





        //output

        Console.WriteLine("Total price = {0}",totalCost);

        Console.ReadLine();
    }
}

