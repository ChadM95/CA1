namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        //lay out variables
        double userGrade, newGrade;

        //user input
        Console.Write("Enter grade > ");
        userGrade = double.Parse(Console.ReadLine());

        //calculate using method
        newGrade = Add15Percent(userGrade);

        Console.WriteLine("Your new grade is > {0:F0}",newGrade);

        Console.ReadLine();

    } // end of main method

    static double Add15Percent(double userGrade)
    {
        if (userGrade > 0 && userGrade <= 100)
        { return userGrade + (userGrade * 0.15); }
        else { return 0;};

    } // end of method

} //end of class

