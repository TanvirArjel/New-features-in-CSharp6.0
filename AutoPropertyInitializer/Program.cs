using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Name = "Tanvir"},
                new Employee() {Name = "Hasan"}
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Employee Id is {0} \t Employee Name {1}", employee.Id, employee.Name);
            }
       
        }
    }

    //Before C#6.0

    //public class Employee
    //{
    //    private Guid _Id;

    //    public Employee()
    //    {
    //        _Id = Guid.NewGuid();
    //    }

    //    public Guid Id
    //    {
    //        get { return this._Id; }
    //    }

    //    public string Name { get; set; }
    //}

    // After C#6.0

    public class Employee
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
    }

}
