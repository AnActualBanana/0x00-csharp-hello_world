 using System;
 
 public static class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        int n = vector.Length;
        if (n != 2 && n != 3)
            return new double[] { -1 };
        double[] result = new double[n];
        for (int i = 0; i < n; i++)
            result[i] = vector[i] * scalar;
        return result;
    }
}
