using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_02_task
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*            Задание 1
                • Вычислить среднее арифметическое значений в диапазоне n – m включительно. 
                */
                int n = 5, m = 10;
                int sum = 0;
                int quantity;
                double average;
                for (int i = n; i <= m; i++)
                {
                    sum += i;
                }
                quantity = m - n + 1;
                average = Convert.ToDouble(sum) / Convert.ToDouble(quantity);
                // result: average  
            }

            {
                /*• Написать код определения суммы четных чисел в диапазоне целых значений 0 – n1, 
                используя только операторы повторения(использование if запрещено). 
                */
                int n1 = 10;
                int sum = 0;
                for (int i = 0; i <= n1; i += 2)
                {
                    sum += i;
                }
                // result: sum
            }

            {
                /*• Написать код определения суммы четных чисел в диапазоне целых значений n1 – n2, 
                используя условные операторы if и операторы повторения.   
                */
                int n1 = 5;
                int n2 = 10;
                int sum = 0;
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2 != 0)
                    {
                        continue;
                    }
                    sum += i;
                }
                // result: sum
            }

            {
                /*            Задание 2
                • Поменять местами значения первого и последнего элементов массива, второго и предпоследнего и тд. 
                Пример: (10, 5, 3, 4) => (4, 3, 5, 10).
                */
                int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int size = mas.Length;
                for (int i = 0; i < size / 2; i++)
                {
                    /* The first way (classic): 

                    int swap;      
                    swap = mas[size - 1 - i];      
                    mas[size - 1 - i] = mas[i];      
                    mas[i] = swap;  
                    */

                    // or another way (without using the third variable): 
                    mas[i] = mas[i] + mas[size - 1 - i];
                    mas[size - 1 - i] = mas[i] - mas[size - 1 - i];
                    mas[i] = mas[i] - mas[size - 1 - i];
                }
                // result: mas (swaped)
            }

            {
                //• Найти расстояние между первым и последним вхождением максимального значения в массиве.
                int[] mas = { 3, 5, 10, 3, 6, 9, 2, 4, 10, 8 };
                int j1 = 0, j2 = 0, distance;
                int max = mas[0];

                for (int i = 0; i < mas.Length; i++)
                {
                    if (max < mas[i])
                    {
                        max = mas[i];
                        j1 = i;
                        j2 = i;
                    }
                    else if (max == mas[i])
                    {
                        j2 = i;
                    }
                }
                distance = j2 - j1;
                // result: distance     
            }

            {
                /*                Задание 3
                • Записать в массив - матрицу произвольного размера значение нуль в элементы 
                по левую сторону главной диагонали, единицу – по правую. Пример:
                               ((2, 4, 3, 3)        ((2, 1, 1, 1)
                                (5, 7, 8, 5)    =>   (0, 7, 1, 1)
                                (2, 4, 3, 3)         (0, 0, 3, 1)
                                (5, 7, 8, 5))        (0, 0, 0, 5))
                */
                int[,] mas = new int[,] { { 1, 2, 5, 8 },
                                          { 3, 4, 2, 6 },
                                          { 5, 6, 8, 9 },
                                          { 7, 9, 5, 5 } };
                double size = Math.Sqrt(mas.Length);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i < j)
                        {
                            mas[i, j] = 1;
                        }
                        else if (i > j)
                        {
                            mas[i, j] = 0;
                        }
                    }
                }
                // result: mas (changed)  
            }
        }
    }
}
