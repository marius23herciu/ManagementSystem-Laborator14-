using ManagementSystem_Laborator14_.Departments;
using System;
using System.Collections.Generic;

namespace ManagementSystem_Laborator14_
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementSystem managementSystem = ManagementSystem.GetManagementSystem();

            Employee robert = new Employee("Robert", 3000);
            Employee andrei = new Employee("Andrei", 2000);
            Employee andreea = new Employee("Andreea", 4000);
            Console.WriteLine(robert);
            List<Department> lliiss = new List<Department>() { Testing.GetTesting(), Maintenance.GetMaintenance(), Logistics.GetLogistics(), HumanResources.GetHumanResources(), Development.GetDevelopmnet() };
            managementSystem.AddDepartment(Testing.GetTesting());
            managementSystem.AddDepartment(Maintenance.GetMaintenance());
            managementSystem.AddDepartment(Logistics.GetLogistics());
            managementSystem.AddDepartment(HumanResources.GetHumanResources());
            managementSystem.AddDepartment(Development.GetDevelopmnet());
            managementSystem.AddEmployee(robert, Testing.GetTesting());
            managementSystem.AddEmployee(andreea, HumanResources.GetHumanResources());
            managementSystem.AddEmployee(andrei, Logistics.GetLogistics());
            managementSystem.RemoveEmployee(robert.ID);
            managementSystem.AddEmployee(robert, Testing.GetTesting());
            try
            {
                managementSystem.RemoveEmployee(Guid.NewGuid());
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            managementSystem.GetNoOfWellPayedEmployees(2050).ForEach(e => Console.WriteLine(e));
            try
            {
                managementSystem.GetNoOfWellPayedEmployees(205000).ForEach(e => Console.WriteLine(e));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(managementSystem.GetMaxSalary());
            List<Department> depList = new List<Department>() { Testing.GetTesting(), HumanResources.GetHumanResources() };
            Employee victor = new Employee("Victor", 8000);
            managementSystem.AddEmployee(victor, Testing.GetTesting());
            try
            {
                List<Employee> bigSalaryByDepartment = managementSystem.GetMaxSalary(depList);
                foreach (var employee in bigSalaryByDepartment)
                {
                    Console.WriteLine(employee);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                List<Employee> bigSalaryByDepartment = managementSystem.GetMaxSalary(new List<Department>());
                foreach (var employee in bigSalaryByDepartment)
                {
                    Console.WriteLine(employee);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(managementSystem.GetTotalCost());
            Console.WriteLine(managementSystem.GetCostForDepartment(Testing.GetTesting()));
            managementSystem.IncreaseSalary(victor.ID, 10);
            managementSystem.IncreaseSalary(Testing.GetTesting(), 10);
            managementSystem.IncreaseSalary(depList, 1);
        }
    }
}
