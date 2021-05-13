using ConsoleApp1.FactoryMethod;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = GetData();

            BaseEmployeeFactory employeeFactory = new EmployeeManagerFactory().CreateFactory(employee);
            employeeFactory.ApplySalary();
            

            //EmployeeManagerFactory employeeManagerFactory = new EmployeeManagerFactory();
            //IEmployeeManager employeeManager = employeeManagerFactory.GetEmployeeManager(employee.Type);
            //employee.Bounus = employeeManager.GetBonus();
            //employee.Pay = employeeManager.GetPay();

            //if(employee.Type == 1)
            //{
            //    employee.Pay = 500;
            //    employee.Bounus = 250;
            //}
            //else if (employee.Type == 2)
            //{
            //    employee.Pay = 300;
            //    employee.Bounus = 100;
            //}

            PrintEmployee(employee);

        }

        static Employee GetData()
        {
            Employee dbEmployee = new Employee();

            Console.Write("Enter employee name : ");
            dbEmployee.Name = Console.ReadLine();

            Console.Write("Enter employee number : ");
            dbEmployee.Number = Console.ReadLine();

            Console.Write("Enter employee type (1/2) : ");
            dbEmployee.Type = int.Parse(Console.ReadLine());

            return dbEmployee;
        }


        static void PrintEmployee(Employee dbEmployee)
        {
            Console.WriteLine("Name : {0}", dbEmployee.Name);
            Console.WriteLine("Number : {0}", dbEmployee.Number);
            Console.WriteLine("Type : {0}", dbEmployee.Type);
            Console.WriteLine("Pay : {0}", dbEmployee.Pay);
            Console.WriteLine("Bonus : {0}", dbEmployee.Bounus);
            Console.WriteLine("House Allowance : {0}", dbEmployee.HouseAllowance);
            Console.WriteLine("Medical Allowance : {0}", dbEmployee.MedicalAllowance);
        }
    }
}
