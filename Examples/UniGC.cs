using System;
using System.Globalization;
using System.IO;
namespace myapp
{
    public abstract class PersonGC
    {
    private string fName;
    private string lName;
    private int age;
    public string FName { get => fName; set => fName = value; }
    public int Age { get => age; set => age = value; }
    public string LName { get => lName; set => lName = value; }

    public PersonGC(string fName, string lName, int age)
    {
        this.FName = fName;
        this.LName = lName;
        this.Age = age;
    }
    public abstract void Test();

    }

    public class StudentIGC : PersonGC
    {
        public StudentIGC(string fName, string lName, int age) : base (fName, lName, age)
        {
            
        }

        public override void Test()
        {
            Console.WriteLine("Student took the test");
        }
         
    }
    public class TeacherIGC : PersonGC
    {
        //public Students[] std1 = new Students[3];
        public StudentIGC[] std1 = new StudentIGC[3];
        
        public TeacherIGC(string fName, string lName, int age) : base (fName, lName, age)
        {
  
        }
        public override void Test()
        {
            Console.WriteLine("Teacher took the test");
        }

    }

    public class UniInheritanceGC : IDisposable
    {
        bool disposed = false;
        StreamWriter sw = null;
        StreamReader streamReaderObject = null;
        

        public void usingUniInheritanceGC()
        {
        var Teacher1 = new TeacherIGC("Lala", "Rukh", 25);
        var Student1 = new StudentIGC("Steve", "Jobs",50);
        var Student2 = new StudentIGC("Bill", "Gates",60);
        var Student3 = new StudentIGC("Bob", "William",40);

        Teacher1.std1[0] = Student1;
        Teacher1.std1[1] = Student2;
        Teacher1.std1[2] = Student3;

        
        try
        {
            using (sw = new StreamWriter("file.txt"))
            {
                foreach (StudentIGC SGC in Teacher1.std1)
                {
                sw.WriteLine(Teacher1.FName + " teaches " + SGC.FName);

                }
            } 
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File could not be written");
        }
        finally
        {
            sw.Close();
            sw = null;
        }

        
        try
        {
            streamReaderObject = new StreamReader("file.txt");
            String contents = streamReaderObject.ReadToEnd();
            Console.WriteLine("The file has {0} text elements", new StringInfo(contents).LengthInTextElements);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file can not be found"); 
        }
        finally
        {
            if(streamReaderObject != null)
            {
                streamReaderObject.Close();
                streamReaderObject = null;
            }
        }

        Console.WriteLine($"{Teacher1.FName} {Teacher1.LName} teaches students {Student1.FName}, {Student2.FName} and {Student3.FName}");
 
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(sw != null)
                    {
                        sw.Close();
                    }
                    if(streamReaderObject !=null)
                    {
                        streamReaderObject.Close();
                    }

            }
            disposed = true;
        }
    }

        ~UniInheritanceGC()
       {
           dispose(false);
       }
        
        
    }
}
