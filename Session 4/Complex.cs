using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        #endregion

        #region Operators Overloading

        public static Complex operator +(Complex Left, Complex Right)
        {

            return new Complex
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Img = (Left?.Img ?? 0) + (Right?.Img ?? 0),
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Img = (Left?.Img ?? 0) - (Right?.Img ?? 0),
            };
        }
        #endregion
    }
}
