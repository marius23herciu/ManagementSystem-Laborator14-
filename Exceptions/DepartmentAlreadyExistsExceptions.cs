using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class DepartmentAlreadyExistsExceptions:Exception
    {
        private const string DepartmentAlreadyExists = "The department already exists.";
        public DepartmentAlreadyExistsExceptions():base(DepartmentAlreadyExists)
        {

        }
    }
}
