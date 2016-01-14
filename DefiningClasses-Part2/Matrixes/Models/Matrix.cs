namespace Matrixes.Models
{
    using System;
    using System.Text;

    class Matrix<T> where T : IComparable<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.Rows = row;
            this.Cols = col;
            this.matrix = new T[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be > 0");                   
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be > 0");                 
                }

                this.cols = value;
            }
        }

        public T this[int indexOfRows, int indexOfCols]
        {
            get
            {
                if (indexOfRows > this.rows - 1 || indexOfRows < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", indexOfRows));
                }

                if (indexOfCols > this.cols - 1 || indexOfCols < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", indexOfCols));
                }
                T result = this.matrix[indexOfRows, indexOfCols];
                return result;
            }

            set { this.matrix[indexOfRows, indexOfCols] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new ArgumentException("These matrices cannot be multiplied");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            T result = (dynamic)0;
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        result += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }
            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    sb.AppendFormat("{0, 3}", this.matrix[row, col]);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
