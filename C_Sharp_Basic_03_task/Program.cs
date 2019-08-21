using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_03_task
{
    class Program
    {
        enum Order
        {
            Asc, // in ascending order                
            Desc // in descending order                         
        }

        /*            Задание 1
        • Описать и вызвать функцию, сортирующую массив значений целого типа произвольной длины
        (по возрастанию или убыванию – задавать отдельным параметром перечислимого типа).
        */
        static void Swap(int[] arr, int i)
        {
            /* The first way (classic): 
                           
            int swap; 
            swap = arr[i];                 
            arr[i] = arr[i + 1];                 
            arr[i + 1] = swap;   
            */

            // or another way (without using the third variable): 
            arr[i] = arr[i] + arr[i + 1];
            arr[i + 1] = arr[i] - arr[i + 1];
            arr[i] = arr[i] - arr[i + 1];
        }
        static void ArraySort(int[] array, Order ord)
        {
            // Sorting the array using the bubble method:              
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (ord == Order.Asc)
                    {
                        if (array[j] > array[j + 1])
                        {
                            Swap(array, j);
                        }
                    }
                    else
                    {
                        if (array[j] < array[j + 1])
                        {
                            Swap(array, j);
                        }
                    }
                }
            }
            // result: array (sorted)                           
        }

        /*• Описать и вызвать функцию, которая определяет, отсортирован ли в заданном порядке 
          массив значений целого типа произвольной длины
        (по возрастанию или убыванию – задавать отдельным параметром перечислимого типа).
        */
        static bool ArraySorted(int[] array, Order ord)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (ord == Order.Asc)
                {
                    if (array[i] > array[i + 1])
                    {
                        return false;
                    }
                }
                else
                {
                    if (array[i] < array[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
            // result: true or false
        }

        /*Задание 2  
        • Написать функцию, возвращающую произведение n элементов арифметической прогрессии чисел 
        с первым элементом a1 и шагом t(an = an - 1 + t)1 

        1 Функция должна возвращать результат для любой арифметической прогрессии, 
        которая задается значениями первого элемента и шага
        */
        static float Mult(float a1, float t, int n)
        {
            float mult = 1.0f;
            for (float i = a1; i <= a1 + (n - 1) * t; i += t)
            {
                mult *= i;
            }
            return mult;
            // result: mult         
        }

        /*• Написать функцию, возвращающую произведение элементов убывающей геометрической прогрессии чисел
        с первым элементом a1 и шагом t, при этом последний элемент должен быть больше alim(an = an - 1 / t, an > alim)2 

            *За выполнение задания №2 ставится оценка выше, если функции описать рекурсивными

        2 Функция должна возвращать результат для любой убывающей геометрической прогрессии, 
         которая задается значениями первого элемента и шага.Также функции можно задавать любой лимит значения 
         последнего используемого члена прогрессии
        */
        // The first way (classic): 
        static float Mult(float a1, float alim, float t)
        {
            float mult = 1.0f;
            for (float i = a1; i > alim; i /= t)
            {
                mult *= i;
            }
            return mult;
            // result: mult    
        }

        // or the second way (using recursion): 
        static float Mult(float ai, float t, float alim, float mult)
        {
            if (ai / t > alim)
            {
                mult *= ai;
                ai = ai / t;
                return Mult(ai, t, alim, mult);
            }
            else
            {
                mult *= ai;
                return mult;
            }
            // result: mult 
        }
        static void Main(string[] args)
        {
            int[] list;
            list = new int[8] { 10, 70, 30, 80, 50, 20, 60, 40 };
            ArraySort(list, Order.Asc);

            int[] arr;
            arr = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            bool arrSorted = ArraySorted(arr, Order.Asc);

            float mult = Mult(5.0f, 0.5f, 3);

            float mult1 = Mult(5.0f, 0.2f, 3.0f);

            float mult2 = Mult(5.0f, 3.0f, 0.2f, 1.0f);
        }
    }
}
