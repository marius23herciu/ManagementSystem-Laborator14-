using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    class Logistics: Department
    {
        #region Singleton
        public static readonly Logistics instance = new Logistics();
        public Logistics()
        {

        }
        public static Logistics GetLogistics()
        {
            return instance;
        }
        #endregion
    }
}
