using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrud
{
    public class Program
    {
        static void Main(string[] args)
        {

            EmployeeCrud crud = new EmployeeCrud();
            int option = 0;
            do
            {
                Console.WriteLine("1.Add Employee Details");
                Console.WriteLine("2.Update Employee Details");
                Console.WriteLine("3.Delete Employee Details");
                Console.WriteLine("1.Display all Employee Details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Employee1 e1 = new Employee1();
                        Console.WriteLine("Enter Employee Id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());

                        crud.AddEmployee(e1);
                        break;

                    case 2:
                        Employee1 e2 = new Employee1();
                        Console.WriteLine("Enter Employee Id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter Employee Id");

                        crud.UpdateEmployee(e2);
                        break;

                    case 3:
                        Console.WriteLine("Enter Employee Id");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(Id);
                        break;

                    case 4:
                        List<Employee1> list = crud.GetEmployee();
                        foreach (Employee1 e in list)
                        {
                            Console.WriteLine($"{e.Id}-{e.Name}-{e.Salary}");
                        }
                        break;
                }
                Console.WriteLine("Enter 1 to Continue");
                option = Convert.ToInt32(Console.ReadLine());

            } while (option == 1);
        }
    }
}
