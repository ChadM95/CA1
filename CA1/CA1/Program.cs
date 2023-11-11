namespace CA1;

class Program
{
    static void Main(string[] args)
    {
        //lay out variables
        string name;
        int day, month, year, daysOld;        

        //input + assign input to variables
        Console.Write("Enter your name > ");
        name = Console.ReadLine();

        Console.WriteLine("Enter your date of birth in dd mm yyyy format:");
        Console.Write("Day > ");
        day = int.Parse(Console.ReadLine());

        Console.Write("month > ");
        month = int.Parse(Console.ReadLine());

        Console.Write("year > ");
        year = int.Parse(Console.ReadLine());

        //instantiate new DateTime object with user input 
        DateTime DateOfBirth = new DateTime(year, month, day);

        //calculate days old using DateTime class 
        daysOld = (DateTime.Today - DateOfBirth).Days;


        //output
        Console.WriteLine("Hello {0}, you are {1} days old.",name,daysOld);

        Console.ReadLine();
    }
}

