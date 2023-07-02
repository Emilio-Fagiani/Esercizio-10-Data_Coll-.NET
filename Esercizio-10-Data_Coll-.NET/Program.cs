using Esercizio_10_Data_Coll_.NET;

class Program
{

    static void Main()
    {

        List<Student> students = new List<Student>()
        {
            new Student("Pippo", 8),
            new Student("Mario", 6),
            new Student("Jack", 7),
            new Student("Mimmo", 10),
            new Student("Erik", 8),
            new Student("Roberto", 5),
            new Student("Gianluca", 6),
            new Student("Ruggero", 9),
            new Student("Dodo", 10),
            new Student("Mimi", 9)
        };
        List<Student> studentsMaxGrade = MaximumGrade(students);
        Console.WriteLine("Students with Highest Grade:");

        foreach (Student student in studentsMaxGrade)
        {
            Console.WriteLine(student.Name);
        }
    }

    static List<Student> MaximumGrade(List<Student> students)
    {
        int studsMaxGrade = students.Max(s => s.Grade);

        List<Student> studentsMaxGrade = students.Where(s => s.Grade == studsMaxGrade)
                                                            .OrderBy(s => s.Name)
                                                            .ToList();
        return studentsMaxGrade;
    }


}

