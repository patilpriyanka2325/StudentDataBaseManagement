using StudentDataBaseManagement.Model;
using MongoDB.Driver;

internal class Program
{
    private static void Main(string[] args)
    {
        //string connctionString = "mongodb://127.0.0.1:27017";
        //string databaseName = "simple_db";
        //string collectionName = "student";

        //var client = new MongoClient(connctionString);
        //var db = client.GetDatabase(databaseName);
        //var collection = db.GetCollection<Student>(collectionName);

        //var student = new Student();

        int choice = 0;
        Student student = new Student();
        Console.WriteLine("***** Welcome To Student Database Management System *****");
        do
        {
            Console.WriteLine("Please select your choice\n 1.Add Student\n 2.View Student\n" +
                " 3.View all students\n 4.Delete student\n 5.Exit");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter student roll no :");
                    var roll = Console.ReadLine();

                    Console.WriteLine("Enter student name :");
                    var name = Console.ReadLine();

                    var newStudent = student.AddStudent(roll, name);
                    Console.WriteLine("Student added : {0}\n{1}", student.Rollno, student.Name);
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