using ManagementSystem_Laborator14_.Departments;
using ManagementSystem_Laborator14_.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_
{
    class ManagementSystem
    {
        #region Singleton
        public static readonly ManagementSystem instance = new ManagementSystem();
        public ManagementSystem()
        {

        }
        public static ManagementSystem GetManagementSystem()
        {
            return instance;
        }
        #endregion

        private List<Employee> listOfEmployees = new List<Employee>();
        public List<Department> listOfDepartments = new List<Department>();
        /// <summary>
        /// Adds a department to management system.
        /// </summary>
        /// <param name="department"></param>
        public void AddDepartment(Department department)
        {
            this.listOfDepartments.ForEach(d =>
            {
                if (d == department)
                {
                    throw new DepartmentAlreadyExistsExceptions();
                }
            });

            this.listOfDepartments.Add(department);
        }
        /// <summary>
        /// Adds an employee by department to managemet system.
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="department"></param>
        public void AddEmployee(Employee employee, Department department)
        {
            Department checkDepartment = this.listOfDepartments.Find(x => x == department);
            if (checkDepartment == null)
            {
                throw new DepatmentDoesntExistException();
            }

            Employee checkEmployee = this.listOfEmployees.Find(x => x == employee);
            if (checkEmployee != null)
            {
                throw new EmployeeAllreadyExistsException();
            }

            department.listOfEmployees.Add(employee);
            this.listOfEmployees.Add(employee);
        }
        /// <summary>
        /// Removes an employee from managment system.
        /// </summary>
        /// <param name="ID"></param>
        public void RemoveEmployee(Guid ID)
        {
            Employee employeeToRemove = null;
            Department deparmentOfEmployee = null;

            this.listOfDepartments.ForEach(department => department.listOfEmployees.ForEach(e =>
            {
                if (e.ID == ID)
                {
                    deparmentOfEmployee = department;
                    employeeToRemove = e;
                }
            }));

            if (employeeToRemove == null)
            {
                throw new IDDoesntExistExeption();
            }

            deparmentOfEmployee.listOfEmployees.Remove(employeeToRemove);
            this.listOfEmployees.Remove(employeeToRemove);
        }
        /// <summary>
        /// Returns a list of employees with salaries bigger than the given parameter.
        /// </summary>
        /// <param name="biggerSalaryThanThis"></param>
        /// <returns></returns>
        public List<Employee> GetNoOfWellPayedEmployees(double biggerSalaryThanThis)
        {
            List<Employee> bigSalaryEmployees = new List<Employee>();

            this.listOfEmployees.ForEach(e =>
            {
                if (e.Salary > biggerSalaryThanThis)
                {
                    bigSalaryEmployees.Add(e);
                }
            });

            if (bigSalaryEmployees.Count == 0)
            {
                throw new NoBiggerSalaryExeption();
            }

            return bigSalaryEmployees;
        }
        /// <summary>
        /// Returns a list of all employees of a given department.
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeesByDepartment(Department department)
        {
            List<Employee> employeesByDepartment = new List<Employee>();
            department.listOfEmployees.ForEach(e =>
            {
                employeesByDepartment.Add(e);
            });
            // sau mai simplu
            //List<Employee> employeesByDepartment = department.listOfEmployees;
            if (employeesByDepartment.Count == 0)
            {
                throw new NoEmployeesException();
            }
            return employeesByDepartment;
        }
        /// <summary>
        /// Returns the employee with the biggest salary from management system.
        /// </summary>
        /// <returns></returns>
        public Employee GetMaxSalary()
        {
            Employee biggestSalaryEmployee = new Employee("empty", -100);
            this.listOfEmployees.ForEach(e =>
            {
                if (e.Salary > biggestSalaryEmployee.Salary)
                {
                    biggestSalaryEmployee = e;
                }
            });
            if (biggestSalaryEmployee.Salary < 0)
            {
                throw new NoEmployeesException();
            }
            return biggestSalaryEmployee;
        }
        /// <summary>
        /// Returns the employee with the biggest salary from a given department.
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public Employee GetMaxSalary(Department department)
        {
            Employee biggestSalaryEmployee = new Employee("empty", -100);
            department.listOfEmployees.ForEach(e =>
            {
                if (e.Salary > biggestSalaryEmployee.Salary)
                {
                    biggestSalaryEmployee = e;
                }
            });
            if (biggestSalaryEmployee.Salary < 0)
            {
                throw new NoEmployeesException();
            }
            return biggestSalaryEmployee;
        }
        /// <summary>
        /// Returns a list of top payed employees from each department in the given list of departments.
        /// </summary>
        /// <param name="departments"></param>
        /// <returns></returns>
        public List<Employee> GetMaxSalary(List<Department> departments)
        {
            Employee biggestSalaryEmployee = new Employee("empty", -100);
            List<Employee> listOfMaxSalaryEmployees = new List<Employee>();

            departments.ForEach(d =>
            {
                if (this.listOfDepartments.Contains(d))
                {
                    this.listOfDepartments.ForEach(dep =>
                    {
                        if (dep == d)
                        {
                            dep.listOfEmployees.ForEach(e =>
                            {
                                if (e.Salary > biggestSalaryEmployee.Salary)
                                {
                                    biggestSalaryEmployee = e;
                                }
                            }
                            );
                            if (biggestSalaryEmployee.Salary >= 0)
                            {
                                listOfMaxSalaryEmployees.Add(biggestSalaryEmployee);
                                biggestSalaryEmployee = new Employee("empty", -100);
                            }
                        };

                    });
                }
            });

            if (listOfMaxSalaryEmployees.Count == 0)
            {
                throw new NoEmployeesException();
            }

            return listOfMaxSalaryEmployees;
        }
        /// <summary>
        /// Returns the total ammount of salaries in  management system.
        /// </summary>
        /// <returns></returns>
        public double GetTotalCost()
        {
            double totalCost = 0;

            this.listOfEmployees.ForEach(e => totalCost += e.Salary);

            return totalCost;
        }
        /// <summary>
        /// Returns the total ammount of salaries from a given department.
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public double GetCostForDepartment(Department department)
        {
            double totalCost = 0;

            department.listOfEmployees.ForEach(e => totalCost += e.Salary);

            return totalCost;
        }
        /// <summary>
        /// Increase salary for an employee by introducing the ID and the percentage of the raise.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="percentage"></param>
        public void IncreaseSalary(Guid ID, double percentage)
        {
            this.listOfEmployees.ForEach(e =>
            {
                if (e.ID == ID)
                {
                    e.Salary += e.Salary * percentage / 100;
                }
            });
        }
        /// <summary>
        /// Increases the salaries for all employees of a given department by the given percentage. 
        /// </summary>
        /// <param name="department"></param>
        /// <param name="percentage"></param>
        public void IncreaseSalary(Department department, double percentage)
        {
            department.listOfEmployees.ForEach(e =>
            {
                e.Salary += e.Salary * percentage / 100;
            });
        }
        /// <summary>
        /// Increases the salaries for all employees of a given list of departments by the given percentage. 
        /// </summary>
        /// <param name="departments"></param>
        /// <param name="percentage"></param>
        public void IncreaseSalary(List<Department> departments, double percentage)
        {
            departments.ForEach(d =>
            {
                IncreaseSalary(d, percentage);
            });
        }
    }
}
