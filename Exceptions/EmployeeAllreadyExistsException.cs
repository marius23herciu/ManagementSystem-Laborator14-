using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class EmployeeAllreadyExistsException:Exception
    {
        private const string EmployeeAllreadyExists = "Employee already exists.";
        public EmployeeAllreadyExistsException():base(EmployeeAllreadyExists)
        {

        }
    }
}
