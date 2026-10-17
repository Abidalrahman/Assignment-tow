using System;

namespace Assignment_tow
{
    public class PartTimeEmployee : Employee , IWorkable
    {
        public double HoursWorked { get; set; }

        public double HourlyRate { get; set; }

        public PartTimeEmployee(int id , string name,double hoursworked , double hourlyrate) : base(id, name)
        {
            HoursWorked = hoursworked;

            HourlyRate = hourlyrate;
        }

        public override double CalculateSalary()
        {
            Salary = HoursWorked * HourlyRate;
            return Salary;
        }

        public void work()
        {
            Console.WriteLine($"{Name} is working part time");
        }
    }
}
