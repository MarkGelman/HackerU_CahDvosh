using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Matrix_Class
{
    class Matrix
    {
        private double[,] _matrix;
        
        public Matrix (int row, int col)
        {
            _matrix = new double[row, col];
        }

        public Matrix(double[,] martix):this(martix.GetLength(0), martix.GetLength(1))
        {
            _matrix = new double[martix.GetLength(0), martix.GetLength(1)];
            //for (int row = 0; row < martix.GetLength(0); row++)
            //    for (int col = 0; col < martix.GetLength(1); col++)
            //        _matrix[row, col] = martix[row, col];
            _matrix = martix.Clone() as double[,];
        }

        public Matrix() : this(5, 5)
        {
            for (int row = 0; row < 5; row++)
                for (int col = 0; col < 5; col++)
                    if (row == col)
                        this._matrix[row, col] = 1;
                    else
                        this._matrix[row, col] = 0;
        }

        public void SetElement(int row, int col, double value)
        {
           
            if (row < 0 || row >= _matrix.GetLength(0) || col < 0 || col >= _matrix.GetLength(1))
                throw new IndexOutOfRangeException("Invalid index.");

            _matrix[row, col] = value;
        }

        public double[] GetRow(int rowIndex)
        {
            double[] row = new double[_matrix.GetLength(1)];
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = _matrix[rowIndex, i];
            }
            return row;
        }
        public double[] GetColumn(int colIndex)
        {
            double[] column = new double[_matrix.GetLength(0)];
            for (int i = 0; i < column.Length; i++)
            {
                column[i] = _matrix[i, colIndex];
            }
            return column;
        }

        //public static Matrix operator +(Matrix a, Matrix b)
        //{
        //    Matrix c = new Matrix(a._matrix.GetLength(0), b._matrix.GetLength(1));
        //    if (a._matrix.GetLength(0) != b._matrix.GetLength(0) || a._matrix.GetLength(1) != b._matrix.GetLength(1))
        //        throw new ArgumentException("Matrices dimensions do not match.");
        //    for (int row = 0; row < a._matrix.GetLength(0); row++)
        //        for (int col = 0; row < a._matrix.GetLength(1); col++)
        //            c._matrix[row, col] = a._matrix[row, col] + b._matrix[row, col];

        //    return c;
        //}

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a._matrix.GetLength(0) != b._matrix.GetLength(0) || a._matrix.GetLength(1) != b._matrix.GetLength(1))
                throw new ArgumentException("Matrices dimensions do not match.");

            int colEnd = a._matrix.GetLength(1) - 1;
            for (int row = 0; row < a._matrix.GetLength(0); row++)
                if (row == 0 || row == a._matrix.GetLength(0) - 1)
                    for (int col = 0; col < a._matrix.GetLength(1); col++)
                        b._matrix[row, col] = a._matrix[row, col];
                else
                {
                    b._matrix[row, 0] = a._matrix[row, 0];
                    b._matrix[row, colEnd] = a._matrix[row, colEnd];
                }

            return b;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a._matrix.GetLength(0), b._matrix.GetLength(1));
            if (a._matrix.GetLength(1) != b._matrix.GetLength(0))
                throw new ArgumentException("Matrices dimensions do not match.");
            for (int a_row = 0; a_row < a._matrix.GetLength(0); a_row++)
                for (int a_col = 0; a_col < a._matrix.GetLength(1); a_col++)
                {

                    for (int  b_col = 0; b_col < b._matrix.GetLength(1); b_col++)
                        for (int b_row = 0; b_row < b._matrix.GetLength(0); b_row++)
                        {
                            c._matrix[a_row, b_col] = a._matrix[a_row, a_col] * b._matrix[b_row, b_col] + a._matrix[a_row, a_col + 1] *
                                                                                                                b._matrix[b_row + 1, b_col];
                            if (b_row + 1 == b._matrix.GetLength(0) - 1)
                                break;
                        }
                    if (a_col + 1 == a._matrix.GetLength(1) - 1)
                        break;
                }
                
                
            return c;
        }

        public double GetSum ()
        {
            double sum = 0;
            for (int row = 0; row < _matrix.GetLength(0); row++)
                for (int col = 0; col < _matrix.GetLength(1); col++)
                    sum += _matrix[row, col];
            return sum;
        }

        public static Matrix GetMaxSumMatrix(params Matrix[] matrices)
        {
            double maxSum = matrices[0].GetSum();
            double sum;
            Matrix maxSumMatrix = matrices[0];
            foreach (Matrix matrix in matrices)
            {
                sum = matrix.GetSum();
                if (sum > maxSum)
                {
                    maxSumMatrix = matrix;
                    maxSum = sum;
                }
            }
                    
            return maxSumMatrix;
        }

        public static Matrix Transpose(Matrix a)
        {
            Matrix b = new Matrix(a._matrix.GetLength(1), a._matrix.GetLength(0));
            for (int col= 0; col < a._matrix.GetLength(0); col++)
                for (int row = 0; row < a._matrix.GetLength(1); row++)
                {
                    b._matrix[row, col] = a._matrix[col, row];
                }

            return b;
        }

        public static explicit operator double[](Matrix a)
        {
            
            double[] array = new double[a._matrix.GetLength(0)*a._matrix.GetLength(1)];
            int i_array = 0;
            for (int row = 0; row < a._matrix.GetLength(0); row++)
                for (int col = 0; col < a._matrix.GetLength(1); col++)
                {

                    array[i_array] = a._matrix[row, col];
                    i_array++;
                }

            return array;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    stringBuilder.Append(_matrix[i, j] + " ");
                }
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }


    }
}
