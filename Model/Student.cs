using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentDataBaseManagement.Model
{
    internal class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Rollno { get; set; }
        public string Name { get; set; }

        public Student(int roll, string name)
        {
            this.Rollno = roll;
            this.Name = name;
        }
    }
}
