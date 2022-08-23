using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class NoEmployeesException: Exception
    {
        private const string NoEmployees = "There are no employees.";

        public NoEmployeesException() : base(NoEmployees)
        {

        }
    }
}
