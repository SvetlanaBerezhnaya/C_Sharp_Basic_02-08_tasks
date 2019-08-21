using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class CustomArray
    {
        /*Создать класс, представляющий пользовательский массив с произвольной нижней границей 
        нумерации элементов(как в Паскале), например, состоящий из 5 элементов с индексами 11, 12, 13, 14, 15. 
        Определить свойства длины массива, нижней и верхней границы индекса, индексатор для чтения и записи 
        элемента по заданному индексу.Класс скомпилировать в динамическую библиотеку.  
        В консольном приложении продемонстрировать работу созданного класса.
        */

        private int lowerIndexBoundary, upperIndexBoundary;
        private int[] numbers = new int[] { 1, 2, 4, 3, 6, 8 };
        public void SetLowerIndexBoundary(int lowerIndexBoundary)
        {
            this.lowerIndexBoundary = lowerIndexBoundary;
        }
        public void SetUpperIndexBoundary(int upperIndexBoundary)
        {
            this.upperIndexBoundary = upperIndexBoundary;
        }
        public int GetLowerIndexBoundary()
        {
            return this.lowerIndexBoundary;
        }
        public int GetUpperIndexBoundary()
        {
            return this.upperIndexBoundary;
        }
        public int ArrayLength()
        {
            return this.upperIndexBoundary - this.lowerIndexBoundary + 1;
        }
        public int this[int i]
        {
            get
            {
                return numbers[i - lowerIndexBoundary];
            }
            set
            {
                numbers[i - lowerIndexBoundary] = value;
            }
        }
    }
}
