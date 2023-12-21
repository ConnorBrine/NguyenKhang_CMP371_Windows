using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>
{
new Employee { ID= 1001, Name = "Priyanka", Salary = 80000 },
new Employee { ID= 1002, Name = "Anurag", Salary = 90000 },
new Employee { ID= 1003, Name = "Preety", Salary = 80000 }
};

            IEnumerable<Employee> result = from emp in listEmployees
                                           where emp.Salary == 80000
                                           select emp;

            listEmployees.Add(new Employee
            {
                ID = 1004,
                Name = "Santosh",
                Salary = 80000
            });

            foreach (Employee emp in result)
            {
                Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
            }
        }
    }
}