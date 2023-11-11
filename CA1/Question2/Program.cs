namespace Question2;

class Program
{
    static void Main(string[] args)
    { 

        //lay out variables
        int basicSeatCost, bags10kg, bags20kg, meals, reservedSeats, totalCost;
        const int BAG10kg_COST = 20, BAG20kg_COST = 30, MEAL_COST = 10, RESERVED_SEAT = 5  ;

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
        totalCost = basicSeatCost + (bags10kg * BAG10kg_COST) + (bags20kg * BAG20kg_COST) + (meals * MEAL_COST) + (reservedSeats * RESERVED_SEAT);

        //output
        Console.WriteLine("Total price = {0}",totalCost);

        Console.ReadLine();
    }
}

