namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        const int SALARY = 24000, HEALTH_INS = 50;
        string name;
        int sales, salesTarget;
        double commission, gross, deductions, total;

        //inputs
        name = AskName();
        sales = AskSales();
        salesTarget = AskSalesTarget();

        //calculations
        commission = CalculateCommission(sales, salesTarget);
        gross = CalculateGross(SALARY, commission);

        deductions = CalculateDeductions(gross, HEALTH_INS);
        total = CalculateTotal(gross,deductions); 
 
        //output
        Console.WriteLine();
        Console.WriteLine($"Take home pay for {name}");
        Console.WriteLine($"Monthly Sales           = {sales}");
        Console.WriteLine($"Commission              = {commission}");
        Console.WriteLine($"Gross Pay               = {gross}");
        Console.WriteLine($"Deductions              = {deductions}");
        Console.WriteLine($"Total                   = {total}");
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
        else if (sales >= salesTarget)
        {
            return (sales * 0.1);
        }
        else { return 0; };
    }

    static double CalculateGross(int annualSalary, double commission)
    {
        return (annualSalary / 12) + commission;
    }

    static double CalculateDeductions(double gross, int healthIns)
    {
        return (gross * 0.20) + (gross * 0.04) + (gross * 0.10) + healthIns;
    }

    static double CalculateTotal(double gross, double deductions)
    {
        return gross - deductions;
    }

}

