using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Part_01_Class
{
    internal class Manager : Employee
    {
        #region Properties
        public string ManagerName { get; set; }
        public int ManagerAge { get; set; }
        public decimal ManagerSalary { get; set; }
        #endregion
        #region Methods
        public override string Work()
        {
            return "Manager is working";
        }
        public override string ToString()
        {
            return $"Name: {ManagerName}, Age: {ManagerAge}, Salary: {ManagerSalary}";
        }
        #endregion
    }
}
