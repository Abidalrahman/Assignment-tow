namespace Assignment_tow
{
    public class FullTimeEmployee : Employee , IWorkable
    {
        public double MonthlySalary { get; set; }
       
        public FullTimeEmployee(int id, string name, double monthlysalary) : base (id ,name)
        {
            MonthlySalary = monthlysalary;
        }

        public override double  CalculateSalary()
        {
            Salary = MonthlySalary;
            return Salary;
        }

        public void work()
        {
            Console.WriteLine($"{Name} is working full time");
        }

    }
}
