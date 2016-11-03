using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpressionBodiedMethodAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {FirstName = "Tanvir", LastName = "Ahmad", YearlySalary = 500000},
                new Employee() {FirstName = "Afifa", LastName = "Sanzida", YearlySalary = 400000}
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Full Name: {employee.FullName} and Montly salary : {employee.MonthlySalary()}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearlySalary { get; set; }

        //Before C#6.0
        //public int MonthlySalary()
        //{
        //    return this.YearlySalary/12;
        //}

        //After C#6.0
        public int MonthlySalary() => this.YearlySalary/12;

        //Before C#6.0
        //public string FullName
        //{
        //    get { return FirstName + ' ' + LastName; }
        //}

        //After C#6.0 

        public string FullName => $"{FirstName} {LastName}";

    }
}
