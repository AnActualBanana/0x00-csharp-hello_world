using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = cos * matrix[i, j] - sin * matrix[j, i];
            }
        }

        return result;
    }
}
