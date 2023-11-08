namespace CA1;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int day, month, year, daysOld;        

        Console.Write("Enter your name > ");
        name = Console.ReadLine();

        Console.WriteLine("Enter your date of birth in dd mm yyyy format:");
        Console.Write("Day > ");
        day = int.Parse(Console.ReadLine());

        Console.Write("month > ");
        month = int.Parse(Console.ReadLine());

        Console.Write("year > ");
        year = int.Parse(Console.ReadLine());


        DateTime DateOfBirth = new DateTime(year, month, day);

        daysOld = (DateTime.Today - DateOfBirth).Days;

        Console.WriteLine("Hello {0}, you are {1} days old.",name,daysOld);

        Console.ReadLine();
    }
}

