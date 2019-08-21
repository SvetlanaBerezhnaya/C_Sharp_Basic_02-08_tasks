using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace ArrayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArray array = new CustomArray();

            array.SetLowerIndexBoundary(11);
            int lowerIndexBoundary = array.GetLowerIndexBoundary();
            Console.WriteLine(lowerIndexBoundary);

            array.SetUpperIndexBoundary(14);
            int upperIndexBoundary = array.GetUpperIndexBoundary();
            Console.WriteLine(upperIndexBoundary);

            int arrayLength = array.ArrayLength();
            Console.WriteLine(arrayLength);

            Console.WriteLine(array[12]);
            array[12] = 111;
            Console.WriteLine(array[12]);

            Console.ReadKey();
        }
    }
}
