using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Part_01_Class
{
    internal class DerivedClass1 : BaseClass
    {
        #region Methods
        public override string DisplayMessage()
        {
            return "Message from DerivedClass1";
        }
        #endregion
    }
}
