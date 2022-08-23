using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class NoBiggerSalaryExeption:Exception
    {
        private const string NoBiggerSalary = "There is no bigger salary than the amount introduced.";
        public NoBiggerSalaryExeption() : base(NoBiggerSalary)
        {
            
        }
    }
}
