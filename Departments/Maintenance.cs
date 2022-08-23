using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSystem_Laborator14_.Departments
{
    class Maintenance: Department
    {
        #region Singleton
        public static readonly Maintenance instance = new Maintenance();
        public Maintenance()
        {

        }
        public static Maintenance GetMaintenance()
        {
            return instance;
        }
        #endregion
    }
}
