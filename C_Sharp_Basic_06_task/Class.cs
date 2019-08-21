using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    /*Задание 1 

     Разработать тип для работы с матрицами из целочисленных значений. 
     Реализовать методы, позволяющие выполнять операции сложения, вычитания и умножения матриц, 
      предусмотрев возможность их выполнения, в противном случае должно генерироваться соответствующее исключение.
    Примечание: в методе main разместить код создания и использования матриц, обрабатывая возникающие при этом исключения
    */
    public class Matrix
    {
        private int[,] elements;
        private int numberOfRows, numberOfColumns;
        public Matrix()
        {
            elements = new int[0, 0];

        }
        public Matrix(int numberOfRows, int numberOfColumns)
        {
            elements = new int[numberOfRows, numberOfColumns];
            this.numberOfRows = numberOfRows;
            this.numberOfColumns = numberOfColumns;
        }
        public void SetNumberOfRows(int numberOfRows)
        {
            this.numberOfRows = numberOfRows;
        }
        public int GetNumberOfRows()
        {
            return this.numberOfRows;
        }
        public void SetNumberOfColumns(int numberOfColumns)
        {
            this.numberOfColumns = numberOfColumns;
        }
        public int GetNumberOfColumns()
        {
            return this.numberOfColumns;
        }
        public void MatrixInitialization(Matrix matrix)
        {
            Random ran = new Random();
            for (int i = 0; i < matrix.GetNumberOfRows(); i++)
            {
                for (int j = 0; j < matrix.GetNumberOfColumns(); j++)
                {

                    matrix[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void MatrixOutput(Matrix matrix)
        {
            for (int i = 0; i < matrix.GetNumberOfRows(); i++)
            {
                for (int j = 0; j < matrix.GetNumberOfColumns(); j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Console.WriteLine("Matrixes have added:");
            if ((matrix1.numberOfRows != matrix2.numberOfRows) || (matrix1.numberOfColumns != matrix2.numberOfColumns))
            {
                throw new ArgumentException("Matrixes can not be added.");
            }
            int numberOfRows3 = matrix1.numberOfRows;
            int numberOfColumns3 = matrix1.numberOfColumns;
            Matrix matrix3 = new Matrix(numberOfRows: numberOfRows3, numberOfColumns: numberOfColumns3);
            for (int i = 0; i < numberOfRows3; i++)
            {
                for (int j = 0; j < numberOfColumns3; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Console.WriteLine("Matrixes have subtracted:");
            if ((matrix1.numberOfRows != matrix2.numberOfRows) || (matrix1.numberOfColumns != matrix2.numberOfColumns))
            {
                throw new ArgumentException("Matrixes can not be subtracted.");
            }
            int numberOfRows3 = matrix1.numberOfRows;
            int numberOfColumns3 = matrix1.numberOfColumns;
            Matrix matrix3 = new Matrix(numberOfRows: numberOfRows3, numberOfColumns: numberOfColumns3);
            for (int i = 0; i < numberOfRows3; i++)
            {
                for (int j = 0; j < numberOfColumns3; j++)
                {
                    matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix3;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Console.WriteLine("Matrixes have multiplicated:");
            if (matrix1.numberOfColumns != matrix2.numberOfRows)
            {
                throw new ArgumentException("Matrixes can not be multiplied.");
            }
            int numberOfRows3 = matrix1.numberOfRows;
            int numberOfColumns3 = matrix2.numberOfColumns;
            Matrix matrix3 = new Matrix(numberOfRows: numberOfRows3, numberOfColumns: numberOfColumns3);
            for (int i = 0; i < numberOfRows3; i++)
            {
                for (int k = 0; k < numberOfColumns3; k++)
                {
                    for (int j = 0; j < matrix1.GetNumberOfColumns(); j++)
                    {
                        matrix3[i, k] += matrix1[i, j] * matrix2[j, k];
                    }
                }
            }
            return matrix3;
        }
        public int this[int i, int j]
        {
            set
            {
                elements[i, j] = value;
            }

            get
            {
                return elements[i, j];
            }
        }
    }
}
