internal class Program
{
    private static void Main(string[] args)
    {
        int choice = 0;
        Console.WriteLine("***** Welcome To Student Database Management System *****");
        do
        {
            Console.WriteLine("Please select your choice\n 1.Add Student\n 2.View Student\n" +
                " 3.View all students\n 4.Delete student\n 5.Exit");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                case 4:
                    Console.WriteLine("4");
                    break;

                case 5:
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("Sorry, invalid selection");
                    return;
            }
        } while (choice != 5);
    }
}