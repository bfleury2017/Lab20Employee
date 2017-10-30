using System;
namespace Lab20Employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private decimal monthlySalary;
        public decimal Salary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value > 0)
                {
                    monthlySalary = value;
                }

            }
        }

        public decimal IncreaseSalary() => (Salary * 10 / 100) + Salary;

        public Employee(string first, string last, int salary)
        {
            FirstName = first;
            LastName = last;
            Salary = salary;

        }

        public void DisplayInformation()
        {
            Console.WriteLine($"{FirstName} {LastName}; yearly salary: {Salary:C}");
        }

        public void DisplayIncrease()
        {
            Console.WriteLine($"{FirstName} {LastName}; yearly salary: {IncreaseSalary():C}");
        }

    }
}
