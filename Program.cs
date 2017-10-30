using System;

namespace Lab20Employee
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee("Bob", "Jones", 34_500);
            Employee employee2 = new Employee("Susan", "Baker", 37_809);

            Console.WriteLine("Employee salary");
            employee1.DisplayInformation();
            employee2.DisplayInformation();
            Console.WriteLine();

            Console.WriteLine("Increasing employee salary by 10%");
            employee1.DisplayIncrease();
            employee2.DisplayIncrease();
        }

    }

}