using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Overloading
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
        // 10 + 5i
        // 6  + 2i
        //========
        // 16 + 7i

        public static Complex operator +(Complex Left, Complex Right)
        {
            //Complex Result = new Complex()
            //{
            //    Real = left.Real + right.Real,
            //    Img = left.Img + right.Img,
            //};
            //return Result;

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

        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Img = C?.Img ?? 0
            };
        }
        public static Complex operator --(Complex C) 
        {

            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Img = C?.Img ?? 0
            };
        }
        public static bool operator >(Complex Left, Complex Right)
        {
            // left.Real > Right.Real => True
            // left.Real < Right.Real => False
            // left.Real == Right.Real
            // Left.Img > Right.Img => True
            // Left.Img < Right.Img => False
            if(Left.Real == Right.Real)
                return Left.Img > Right.Img;
            else
                return Left.Real > Right.Real;
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Img < Right.Img;
            else
                return Left.Real < Right.Real;
        }

        #endregion

    }
}
