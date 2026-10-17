using Assignment_tow;

FullTimeEmployee employee1 = new FullTimeEmployee(1, "Abidalrahman", 1200);
PartTimeEmployee employee2 = new PartTimeEmployee(2, "Omar", 20 , 20);

employee1.CalculateSalary();
employee2.CalculateSalary();

employee1.DisplayInfo();
employee2.DisplayInfo();

employee1.work();
employee2.work();
