using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLibrary;

namespace MatrixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(numberOfRows: 3, numberOfColumns: 3);
            Console.WriteLine("Matrix1:");
            matrix1.MatrixInitialization(matrix1);

            Matrix matrix2 = new Matrix(numberOfRows: 3, numberOfColumns: 3);
            Console.WriteLine("Matrix2:");
            matrix2.MatrixInitialization(matrix2);

            Matrix matrix3 = new Matrix();
            matrix3 = matrix1 + matrix2;
            matrix3.MatrixOutput(matrix3);

            matrix3 = matrix1 - matrix2;
            matrix3.MatrixOutput(matrix3);

            matrix3 = matrix1 * matrix2;
            matrix3.MatrixOutput(matrix3);

            Console.ReadLine();
        }
    }
}
