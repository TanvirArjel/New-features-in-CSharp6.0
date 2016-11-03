using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = null;

            //Before C#6.0
            //if (employee.FirstName != null)
            //{
            //    Console.WriteLine(employee.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("FirstName is null");
            //} 

            //After C#6.0

            var firstName = employee?.FirstName ?? "FirstName is null";
            Console.WriteLine(firstName);


        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
    }
}
