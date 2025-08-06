using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Employee
    {
        #region Properties
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public decimal EmpSalary { get; set; }
        #endregion
        #region Methods
        public virtual string Work()
        {
            return "Employee is working";
        }
        public override string ToString()
        {
            return $"Name: {EmpName}, Age: {EmpAge}, Salary: {EmpSalary}";
        }
        #endregion
    }
}
