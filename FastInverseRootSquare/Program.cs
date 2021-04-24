using System;

namespace FastInverseRootSquare
{
    public static class Program
    {
        public static double UsualInverseSquareRoot(double x)
        {
            return 1 / Math.Sqrt(x);
        }

        public static float UsualInverseSquareRoot(float x)
        {
            return 1 / (float) Math.Sqrt(x);
        }

        public static unsafe float QuakeInverseSquareRoot(float x) //can be only float, for double another values need to be added
        {
            long i;
            float x2, y;
            const float threehalfs = 1.5f;

            x2 = x * 0.5f;
            y = x;
            i = *(long*)&y;
            i = 0x5f3759df - (i >> 1);
            y = *(float*) &i;

            y = y * (threehalfs - (x2 * y * y));
            // y = y * (threehalfs - (x2 * y * y)); - for bigger accuracy

            return y;
        }

        public static float FastInverseSquareRoot(float x)
        {
            var integer = BitConverter.SingleToInt32Bits(x);
            int sum = 1597488759 - (integer >> 1);
            var y = BitConverter.Int32BitsToSingle(sum);

            y *= 1.5f - 0.5f * x * y * y;
            return y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("You need to run Unit Test, not the app!~");
        }
    }
}
