namespace Matrixes
{
    using Matrixes.Models;
    using System;

    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> matrixA = GenerateMatrix(4, 3, 1);
            Matrix<int> matrixB = GenerateMatrix(4, 3, 2);
            //matrix for multiplication
            Matrix<int> matrixC = GenerateMatrix(3, 4, 1);

            Console.WriteLine("matrixA \n{0}", matrixA);
            Console.WriteLine("matrixB \n{0}", matrixB);
            Console.WriteLine("matrixC \n{0}", matrixC);

            Console.WriteLine("matrixA + matrixB");
            Matrix<int> additionOfMatrices = matrixA + matrixB;
            Console.WriteLine(additionOfMatrices);

            Console.WriteLine("matrixB - matrixA");
            Matrix<int> subtractionOfMtrices = matrixB - matrixA;
            Console.WriteLine(subtractionOfMtrices);

            Console.WriteLine("matrixA * matrixC");
            Matrix<int> multiplicationOfMtrices = matrixA * matrixC;
            Console.WriteLine(multiplicationOfMtrices);
        }

        static Matrix<int> GenerateMatrix(int row, int col, int number)
        {
            Matrix<int> matrix = new Matrix<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = r + c + number;
                }
            }

            return matrix;
        }
    }
}
