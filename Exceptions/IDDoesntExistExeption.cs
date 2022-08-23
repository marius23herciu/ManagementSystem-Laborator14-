using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Exceptions
{
    class IDDoesntExistExeption:Exception
    {
        private const string InexistentID = "The ID introduced doesn't exist in the database.";
        public IDDoesntExistExeption() : base(InexistentID)
        {

        }
    }
}
