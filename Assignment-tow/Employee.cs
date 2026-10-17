using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_tow
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get;  set; }

        private double _Salary;
        public double Salary {
            get
            {
                return _Salary;
            }
             protected set
            {
                _Salary = value;
            } 
        }

        public  Employee(int id,string name)
        {
            Id = id;

            Name = name;
        }

        public abstract double CalculateSalary();

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee Id : {Id}");
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee Salary : {Salary}");
        }
    }
}
