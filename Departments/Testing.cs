using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    class Testing:Department
    {
        #region Singleton
        public static readonly Testing instance = new Testing();
        public Testing()
        {

        }
        public static Testing GetTesting()
        {
            return instance;
        }
        #endregion
    }
}
