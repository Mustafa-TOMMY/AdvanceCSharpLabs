namespace LabDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Ahmed",
                    Subjects = new[] { "Math", "Physics", "Programming" },
                    Grades = new[] { 15, 18, 20 }
                },
                new Student
                {
                    Id = 2,
                    Name = "Ali",
                    Subjects = new[] { "Math", "English", "Database" },
                    Grades = new[] { 14, 16, 19 }
                },
                new Student
                {
                    Id = 3,
                    Name = "Amr",
                    Subjects = new[] { "Physics", "Programming", "AI" },
                    Grades = new[] { 17, 18, 16 }
                },
                new Student
                {
                    Id = 4,
                    Name = "Mohamed",
                    Subjects = new[] { "Math", "OOP", "Database" },
                    Grades = new[] { 13, 15, 17 }
                },
                new Student
                {
                    Id = 5,
                    Name = "Omar",
                    Subjects = new[] { "Networking", "Security", "Linux" },
                    Grades = new[] { 18, 17, 16 }
                },
                new Student
                {
                    Id = 6,
                    Name = "Hassan",
                    Subjects = new[] { "Math", "Statistics", "AI" },
                    Grades = new[] { 12, 14, 15 }
                },
                new Student
                {
                    Id = 7,
                    Name = "Ibrahim",
                    Subjects = new[] { "Programming", "OOP", "Algorithms" },
                    Grades = new[] { 19, 18, 20 }
                },
                new Student
                {
                    Id = 8,
                    Name = "Youssef",
                    Subjects = new[] { "English", "Database", "Web" },
                    Grades = new[] { 14, 16, 15 }
                },
                new Student
                {
                    Id = 9,
                    Name = "Abdullah",
                    Subjects = new[] { "Math", "Physics", "Electronics" },
                    Grades = new[] { 17, 16, 18 }
                },
                new Student
                {
                    Id = 10,
                    Name = "Ayman",
                    Subjects = new[] { "AI", "Data Science", "Python" },
                    Grades = new[] { 20, 19, 18 }
                }
            };


            #region user input 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}");

            //    Console.Write("Id: ");
            //    int.TryParse(Console.ReadLine(), out int id);

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Number of subjects: ");
            //    int.TryParse(Console.ReadLine(), out int subCount);

            //    string[] subjects = new string[subCount];
            //    int[] grades = new int[subCount];

            //    for (int j = 0; j < subCount; j++)
            //    {
            //        Console.Write($"Subject {j + 1} name: ");
            //        subjects[j] = Console.ReadLine();

            //        Console.Write($"Grade for {subjects[j]}: ");
            //        grades[j] = int.Parse(Console.ReadLine());
            //    }

            //    students.Add(new Student
            //    {
            //        Id = id,
            //        Name = name,
            //        Subjects = subjects,
            //        Grades = grades
            //    });

            //    Console.WriteLine();
            //} 
            #endregion



            var nameStartsWithA = from stu in students
                                  where stu.Name.StartsWith("A")
                                  select stu;

            var totalGreaterThan50 = students.Where(s => s.TotalGrades() > 50);



            Console.WriteLine("Students names start with A:");
            foreach (var s in nameStartsWithA)
            {
                string studentdata = s.ToString();
                Console.WriteLine(studentdata);
            }
            Console.WriteLine("===================================");

            Console.WriteLine("Students with total grades > 50:");
            foreach (var s in totalGreaterThan50)
            {
                Console.WriteLine($"{s.Name} and TotalGrades = {s.TotalGrades()}");
            }






            //for (int i = 0; i < nameStartsWithA.Count(); i++)
            //{
            //    Console.WriteLine($"Student number {i+1}: {nameStartsWithA.ElementAt(i).Name} and TotalGrade: {nameStartsWithA.ElementAt(i).TotalGrades()}");
            //    Console.WriteLine("=======================");
            //}
        }

    }
}

