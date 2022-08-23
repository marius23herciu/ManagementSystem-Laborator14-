using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    class Development:Department
    {
        #region Singleton
        public static readonly Development instance = new Development();
        public Development()
        {

        }
        public static Development GetDevelopmnet()
        {
            return instance;
        }
        #endregion
    }
}
