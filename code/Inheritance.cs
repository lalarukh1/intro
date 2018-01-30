using System;
namespace myapp
{
    class Employee
    {
        //private String EmpName;
        //private double EmpBaseSalary;
        //private int EmpID;

        public String Name {get; set; }
        public double BaseSalary {get; set; }
        public int ID {get; set; }
        //Making this field static will produce the right result-otherwise not
        private  static int employeeCount = 1;
        public Employee (String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount ++;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public String getName()
        {
            return this.Name;
        }
        public int getID ()
        {
            return this.ID;
        }
        public String toString()
        {
            String EID = this.ID + " " + this.Name;
            return EID;
        }
        public virtual String EmployeeStatus()
        {
            String eid = toString();
            //Console.WriteLine("{0} is in the company's system", eid);
            return eid + " is in Company's system";        
        }
    
    }
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(String name) : base (name, 75000)
        {
            //this.Name = name;
        }
        private int successfulCheckIns = 5;

        public int SuccessfulCheckIns { get => successfulCheckIns; set => successfulCheckIns = value; }

        public override String EmployeeStatus ()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful Check-Ins";
        }

    }
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(String name) : base (name, 50000)
        {
            //this.Name = name;
        }
        public double bonusBudget = 1000;

        public override String EmployeeStatus ()
        {
            return this.toString() + " has a budget of " + this.bonusBudget ;
        }
        
    }

    class Inheritance
    {
        public void usingInheritance()
        {
        var employee1 = new Employee("Lala Rukh", 3000);
        var employee2 = new TechnicalEmployee("Tommy");
        var employee3 = new BusinessEmployee("Hilfiger");
        Console.WriteLine(employee1.EmployeeStatus());
        Console.WriteLine(employee2.EmployeeStatus());
        Console.WriteLine(employee3.EmployeeStatus());
        }
    }
}
