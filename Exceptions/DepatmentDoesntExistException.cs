using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class DepatmentDoesntExistException:Exception
    {
        private const string DepatmentDoesntExists = "Department doesn't exist.";
        public DepatmentDoesntExistException():base (DepatmentDoesntExists)
        {

        }
    }
}
