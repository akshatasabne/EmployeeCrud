using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrud
{
    public class Employee1
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class EmployeeCrud
    {
        private List<Employee1> employees;

        public EmployeeCrud()
        {
            new List<Employee1>();
        }
        public void AddEmployee(Employee1 employee)
        {
            employees.Add(employee);
        }
        public void UpdateEmployee(Employee1 employee)
        {
            foreach (Employee1 employee1 in employees)
            {
                if (employee1.Id == employee.Id)
                {
                    employee1.Name = employee.Name;
                    employee1.Salary = employee.Salary;

                }
            }
        }
        public void DeleteEmployee(int Id)
        {
            foreach (Employee1 employee1 in employees)
            {
                if (employee1.Id == Id)
                {
                    employees.Remove(employee1);
                }
            }
        }
        public List<Employee1> GetEmployee()
        {
            return employees;
        }
    }
}
