using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    class HumanResources:Department
    {
        #region Singleton
        public static readonly HumanResources instance = new HumanResources();
        public HumanResources()
        {

        }
        public static HumanResources GetHumanResources()
        {
            return instance;
        }
        #endregion
    }
}
