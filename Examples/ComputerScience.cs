using System;

namespace myapp
{
    public class Student
    {
        public String FName { get; set; }
        public String LName {get; set; }
        public int Age {get; set; }

        private static int instances;
        
        public Student()
        {
            instances++;
        }

        public Student(String FName, String LName, int Age)
        {
            this.FName = FName;
            this.LName = LName;
            this.Age = Age;
            instances++;
        }

        public static int countStudents ()
        {
            return instances;
        }

    }

    public class Teacher
    {
        public String TeachName {get; set;}
        public String City {get; set;}
    }

    public class UProgram
    {
        public String ProgName {get; set;}
        
        public Degree Deg1 = new Degree();
        
    }

    public class Degree
    {
        public String DegName {get; set; }
    }

    public class Course 
    {
        public String CourseName {get; set; }
        public Student[] std1 = new Student[3];
        public Teacher teach1 = new Teacher();

    }

    public class ComputerScience
    {
        public void usingCompScience()
        {
        var UProgram1 = new UProgram();
        UProgram1.ProgName = "Information Technology";
        var Degree1 = new Degree();
        Degree1.DegName = "Masters";
        UProgram1.Deg1 = Degree1;
        
        var Course1 = new Course();
        Course1.CourseName = "Programming";
        var stud1 = new Student();
        stud1.FName = "Lala";
        stud1.LName = "Rukh";
        stud1.Age = 25;
        var stud2 = new Student("Mohsin", "Yasin", 30);
        var stud3 = new Student("Big", "Show", 50);
        Course1.std1[0] = stud1;
        Course1.std1[1] = stud2;
        Course1.std1[2] = stud3;

        var teach1 = new Teacher();
        teach1.TeachName = "Donald Duck";
        Course1.teach1 = teach1;

        int studCount = Student.countStudents();
        Console.WriteLine($"The program {UProgram1.ProgName} contains {Degree1.DegName}");
        Console.WriteLine($"The degree {Degree1.DegName} has course {Course1.CourseName} ");
        Console.WriteLine($"Total students in the course are {studCount}");
        }

    }
}