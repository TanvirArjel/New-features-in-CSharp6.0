using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {FirstName = "Tanvir", LastName = "Ahmad"},
                new Employee() {FirstName = "Afifa", LastName = "Sanzida"}
            };
            foreach (Employee employee in employees)
            {
                //Before C#6.0
                //var fullName = string.Format("Full Name is: {0} {1}",employee.FirstName, employee.LastName);
                //Console.WriteLine(fullName);

                //After C#6.0
                var fullName = $"Full Name is : {employee.FirstName} {employee.LastName}";
                Console.WriteLine(fullName);


            }
        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
