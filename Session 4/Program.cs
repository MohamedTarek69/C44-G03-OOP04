using Session_4.Overloading;

namespace Session_4
{
    internal class Program
    {
        static int SumNumbers(int x, int y)
        {
            return x + y;
        }
        static int SumNumbers(int x, int y, int z)
        {
            return x + y + z;
        }
        static double SumNumbers(double x, double y)
        {
            return x + y;
        }
        
        static double SumNumbers(double x, int y)
        {
            return x + y;
        }
        
        static double SumNumbers(int x, double y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            //----------------------------------- Vedio 02 -------------------------------------
            #region Method Overloading 
            //int A = 10 , B = 20 , C = 30 ;
            //int Result = SumTwoNumbers(A, B);
            //int Result = SumThreeNumbers(A, B, C);
            //double Result = SumDoubleTwoNumbers(A, B);
            //double Result = SumNumbers();
            //Console.WriteLine(Result);

            //Console.WriteLineInt()
            //Console.WriteLineString()
            //Console.WriteLineFloat()

            //Console.WriteLine(); 
            #endregion

            //----------------------------------- Vedio 03 -------------------------------------
            //5 + 4i
            Complex C1 = new Complex
            {
                Real = 10,
                Img = 5
            };

            Console.WriteLine($"C1 => {C1}");

            Complex C2 = new Complex() { Real = 6, Img = 2 };
            Console.WriteLine($"C2 => {C2}");

            //Complex C3 = C1 + C2;
            //Console.WriteLine("==============");
            //Console.WriteLine($"C3 => {C3}");

            //Complex C3 = C1 - C2;
            //Console.WriteLine("==============");
            //Console.WriteLine($"C3 => {C3}");

            //----------------------------------- Vedio 04 -------------------------------------
            //Console.WriteLine("==============");
            //C3++;
            //Console.WriteLine($"C3 => {C3}");

            //Console.WriteLine("==============");
            //C3--;
            //Console.WriteLine($"C3 => {C3}");

            //----------------------------------- Vedio 05 -------------------------------------
            Console.WriteLine("==============");
            if (C1 > C2)
                Console.WriteLine("C1 > C2");
            else
                Console.WriteLine("C1 < C2");


        }
    }
}
