namespace CA1;

class Program
{
    static void Main(string[] args)
    {
        DateTime MyDate = new DateTime();

        /*   Console.WriteLine("Enter your Date of Birth...");
           Console.Write("Year > ");*/

        MyDate.AddYears(2023);

        Console.WriteLine(MyDate);
        Console.ReadLine();
    }
}

