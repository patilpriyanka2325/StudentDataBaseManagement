using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentDataBaseManagement.Model
{
    internal class Student
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string Rollno { get; set; }
        public string Name { get; set; }

        public Student(string roll, string name)
        {
            this.Rollno = roll;
            this.Name = name;
        }

        public Student() { }

        public Student AddStudent(string roll, string name) 
        {
            return new Student(roll, name);
        }
    }
}
