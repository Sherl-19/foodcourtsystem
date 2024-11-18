using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    class Cashier
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        public string Shift { get; set; }
        public decimal Salary { get; set; }

        public Cashier(string firstName, string lastName, int employeeId, string shift, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            Shift = shift;
            Salary = salary;
        }
    }
}
