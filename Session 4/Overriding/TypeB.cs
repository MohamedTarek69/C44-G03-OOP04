using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Overriding
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; }

        #endregion

        #region Constructors
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        #endregion

        #region Methods
        // Using "New" to Hiding inherit member TypA.MyFun01() [New Virision - Masking]
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun03 from TypeB.");
        }

        // Using Keyword "override" inherit member TypA.MyFun02()
        // TypA.MyFun02() Must be Marked as Virtual Method and Non - Private in its first Appearance
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB | A => {A}, B => {B}");
        }

        #endregion
    }
}
