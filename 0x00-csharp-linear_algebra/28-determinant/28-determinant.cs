using System;

public class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        if (row != col)
        {
            return -1;
        }
        else if (row == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (row == 3)
        {
            return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                   matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                   matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
                   matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                   matrix[0, 1] * matrix[1, 0] * matrix[2, 2] -
                   matrix[0, 0] * matrix[1, 2] * matrix[2, 1];
        }
        else
        {
            return -1;
        }
    }
}
