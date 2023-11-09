namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int sales, salesTarget;
        int salary = 24000;
        double commission;

        //inputs
        name = AskName();
        sales = AskSales();
        salesTarget = AskSalesTarget();

        //calculations
        commission = CalculateCommission(sales, salesTarget);


        //output
        Console.WriteLine();
        Console.WriteLine("Take home pay for");

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

    static double CalculateCommission(int sales, int salesTarget )
    {
        if (sales < salesTarget)
        {
            return (sales * 0.05);
        }
        else if (sales > salesTarget)
        {
            return (sales * 0.1);
        }
    }


}

