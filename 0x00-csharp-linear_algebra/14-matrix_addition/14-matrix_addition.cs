using System;

public static class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        if (rows1 != rows2 || columns1 != columns2)
            return new double[,] { { -1 } };

        double[,] result = new double[rows1, columns1];

        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < columns1; j++)
                result[i, j] = matrix1[i, j] + matrix2[i, j];

        return result;
    }
}
