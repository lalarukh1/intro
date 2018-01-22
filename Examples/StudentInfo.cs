using System;

namespace myapp
{
    class StudentInfo
    {
        String firstName;
        String secondName;
        String age;
        String courseName;
        String teachName;
        static void getStudentInfo(out String firstName, out String secondName, out String age)
        {
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter second name:");
            secondName = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = Console.ReadLine();
        }

        static void getCourseInfo(ref String courseName, ref String teachName)
        {
            Console.WriteLine("Enter Course name:");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter teacher name:");
            teachName = Console.ReadLine();
        }

        static void printStudDetails(String firstName, String secondName, string age)
        {
            Console.WriteLine("Student {0} {1} is {2} years old",firstName, secondName, age);
        }

        public void printCourseDetails(String courseName,String teachName)
        {
            Console.WriteLine("{0} teaches the course {1}",teachName, courseName);
        }

        public void usingDetails()
        {
            getStudentInfo(out firstName, out secondName, out age);
            printStudDetails(firstName,secondName,age);
            getCourseInfo(ref courseName, ref teachName);
            printCourseDetails(courseName, teachName);
            Console.WriteLine("{0} studies {1} course taught by {2}",firstName,courseName,teachName);
            try
            {
                universityDetails();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to implement university details");
            }
        }

        public void universityDetails()
        {
            throw new NotImplementedException();
        }





    }
}