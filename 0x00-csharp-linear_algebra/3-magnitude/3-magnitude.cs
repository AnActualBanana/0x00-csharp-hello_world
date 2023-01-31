using System;

namespace VectorMath
{
    public class Vector
    {
        public static double Magnitude(double[] vector)
        {
            if (vector.Length != 2 && vector.Length != 3)
                return -1;

            double sumOfSquares = 0;
            foreach (double component in vector)
                sumOfSquares += component * component;

            return Math.Round(Math.Sqrt(sumOfSquares), 2);
        }
    }
}
