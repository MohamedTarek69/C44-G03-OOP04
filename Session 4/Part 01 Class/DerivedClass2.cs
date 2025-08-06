using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Part_01_Class
{
    internal class DerivedClass2 : BaseClass
    {
        #region Methods
        public new string DisplayMessage()
        {
            return "Message from DerivedClass2";
        }
        #endregion
    }
}
