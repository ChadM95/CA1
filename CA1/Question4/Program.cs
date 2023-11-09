namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int monthlySales, salesTarget;

        name = AskName();

        monthlySales = AskSales();

        salesTarget = AskSalesTarget();


        Console.ReadLine();
    }

    static string AskName()
    {
        Console.Write("Enter name > ");
        return Console.ReadLine();
    }

    static int AskSales()
    {
        Console.Write("Enter monthly sales > ");
        return int.Parse(Console.ReadLine());
    }

    static int AskSalesTarget()
    {
        Console.Write("Enter monthly sales target > ");
        return int.Parse(Console.ReadLine());
    }
}

