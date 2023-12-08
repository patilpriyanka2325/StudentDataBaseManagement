internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Welcome To Student Database Management System *****");
        Console.WriteLine("Please select your choice\n 1.Add Student\n 2.View Student\n" +
            " 3.View all students\n 4.Delete student\n 5.Exit");

        var choice = Console.ReadLine();
    }
}