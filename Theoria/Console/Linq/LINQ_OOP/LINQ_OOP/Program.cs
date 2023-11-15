
using LINQ_OOP;

internal class Program
{
    static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Grade = 91 ,CourseId=1},
            new Student { Id = 2, Name = "Bob", Grade = 85 ,CourseId=1},
            new Student { Id = 3, Name = "Charlie", Grade = 78 ,CourseId=2},
            new Student { Id = 4, Name = "David", Grade = 33 ,CourseId=1},
            new Student { Id = 5, Name = "Eve", Grade = 88 , CourseId = 2},
            new Student { Id = 6, Name = "Frank", Grade = 26 , CourseId = 1},
            new Student { Id = 7, Name = "Grace", Grade = 89    , CourseId = 3},
            new Student { Id = 8, Name = "Hannah", Grade = 42 , CourseId = 3},
            new Student { Id = 9, Name = "Ian", Grade = 75 , CourseId = 3},
           new Student { Id = 10, Name = "Jane", Grade = 91 , CourseId = 3},


        };

    static void Main(string[] args)
    {
        var groupByCourse = students.GroupBy(s => s.CourseId).ToDictionary(group => group.Key, group => group.Where(s => s.Grade == group.Max(s => s.Grade)));

        foreach (var group in groupByCourse)
        {
            Console.WriteLine($"Course id {group.Key}:");

            foreach (var student in group.Value)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }    
}
