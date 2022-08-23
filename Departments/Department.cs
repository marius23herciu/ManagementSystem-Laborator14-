using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    abstract class Department
    {
        public List<Employee> listOfEmployees = new List<Employee>();
        public Department()
        {

        }
    }
}
