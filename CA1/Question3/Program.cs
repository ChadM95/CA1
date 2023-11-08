namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        double oldGrade, newGrade;

        Console.Write("Enter grade > ");
        oldGrade = double.Parse(Console.ReadLine());

        newGrade = Add15Percent(oldGrade);

        Console.WriteLine("Your new grade is > {0:F0}",newGrade);

        Console.ReadLine();
    }

    static double Add15Percent(double userGrade)
    {
        if (userGrade > 0 && userGrade <= 100)
        { return userGrade + (userGrade * 0.15); }
        else { return 0;};
    }
}

