using System;


public class MatrixOperations
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows != columns || rows <= 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];
        double[,] shearMatrix = new double[rows, columns];

        switch (Char.ToUpper(direction))
        {
            case 'X':
                shearMatrix[0, 1] = factor;
                break;
            case 'Y':
                shearMatrix[1, 0] = factor;
                break;
            default:
                return new double[,] { { -1 } };
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < columns; k++)
                {
                    result[i, j] += matrix[i, k] * shearMatrix[k, j];
                }
            }
        }

        return result;
    }
}
