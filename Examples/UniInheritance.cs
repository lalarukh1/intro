using  System;
namespace myapp
{
    public abstract class Person
    {
    private string fName;
    private string lName;
    private int age;
    public string FName { get => fName; set => fName = value; }
    public int Age { get => age; set => age = value; }
    public string LName { get => lName; set => lName = value; }

    public Person(string fName, string lName, int age)
    {
        this.FName = fName;
        this.LName = lName;
        this.Age = age;
    }
    public abstract void Test();

    }

    public class StudentI : Person
    {
        public StudentI(string fName, string lName, int age) : base (fName, lName, age)
        {
            
        }

        public override void Test()
        {
            Console.WriteLine("Student took the test");
        }
         
    }

    public class TeacherI : Person
    {
        //public Students[] std1 = new Students[3];
        public StudentI[] std1 = new StudentI[3];
        
        public TeacherI(string fName, string lName, int age) : base (fName, lName, age)
        {
        
        
          
        }
        public override void Test()
        {
            Console.WriteLine("Teacher took the test");
        }

    }

    public class UniInheritance
    {
        public void usingUniInheritance()
        {
        var Teacher1 = new TeacherI("Lala", "Rukh", 25);
        var Student1 = new StudentI("Steve", "Jobs",50);
        var Student2 = new StudentI("Bill", "Gates",60);
        var Student3 = new StudentI("Bob", "William",40);

        Teacher1.std1[0] = Student1;
        Teacher1.std1[1] = Student2;
        Teacher1.std1[2] = Student3;

        Console.WriteLine($"{Teacher1.FName} {Teacher1.LName} teaches students {Student1.FName}, {Student2.FName} and {Student3.FName}");
        Teacher1.Test();
        Student1.Test();
        
        }
        
        
    }
}
