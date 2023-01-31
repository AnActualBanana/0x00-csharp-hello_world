using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        public static double[,] Inverse2D(double[,] matrix)
        {
            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            {
                return new double[,] { { -1 } };
            }

            double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            if (determinant == 0)
            {
                return new double[,] { { -1 } };
            }

            double[,] inverse = new double[2, 2];
            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }
    }
}
