using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class Matrix<T>
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        //fields
        T[,] matrix;

        //properties
        public int Rows
        {
            get
            {
                return matrix.GetLength(0);
            }
        }
        public int Cols
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        //Constructor for building a matrix
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        //indexer
        public T this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        //Matrix operations
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(1) != m2.matrix.GetLength(0))
            {
                throw new OperationCanceledException("Not possible to multiply!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));

                for (int i = 0; i < result.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < result.matrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < m1.matrix.GetLength(1); k++)
                        {
                            result[i, j] += (dynamic)m1[i, k] * (dynamic)m2[k, j];
                        }
                    }
                }

                return result;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) == m2.matrix.GetLength(0) &&
                m1.matrix.GetLength(1) == m2.matrix.GetLength(1))
            {
                Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

                for (int i = 0; i < m1.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.matrix.GetLength(1); j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Expecting the same rows and cols!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) == m2.matrix.GetLength(0) &&
                m1.matrix.GetLength(1) == m2.matrix.GetLength(1))
            {
                Matrix<T> result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

                for (int i = 0; i < m1.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.matrix.GetLength(1); j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new ArgumentException("Expecting the same rows and cols!");
            }
        }

        //True/false matrix
        public static bool operator true(Matrix<T> testMatrix)
        {
            bool isNonZero = true;

            for (int i = 0; i < testMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.matrix.GetLength(1); j++)
                {
                    if ((dynamic)testMatrix[i, j] == 0)
                    {
                        isNonZero = false;
                    }
                }
            }

            return isNonZero;
        }
        public static bool operator false(Matrix<T> testMatrix)
        {
            bool isNonZero = true;

            for (int i = 0; i < testMatrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < testMatrix.matrix.GetLength(1); j++)
                {
                    if ((dynamic)testMatrix[i, j] == 0)
                    {
                        isNonZero = false;
                    }
                }
            }

            return isNonZero;
        }

        public void  PrintMatrix()
        {
            for(int row = 0; row < this.matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                     Console.Write("{0}, ", this.matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
