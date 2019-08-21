using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_04_task
{
    class Program
    {
        /*Задание 1
        • Создать класс Квадрат определить функционал класса так, чтобы он соответствовал
        геометрической фигуре «квадрат» (задание стороны, вычисление периметра и площади). 
        */
        public class Square
        {
            private double side;
            public void SetSide(double side)
            {
                if (side <= 0)
                {
                    side = 1;
                }
                this.side = side;
            }
            public double GetPerimeter()
            {
                return (this.side * 4);
            }
            public double GetSquare()
            {
                return (this.side * this.side);
            }
        }

        /*Задание 2 
        • Создать класс Арифметическая прогрессия1.Обеспечить получение (задание) характеристик прогрессии.
        Функционал класса: 
              o первый член прогрессии, 
              o разница прогрессии, 
              o n–й член прогрессии, 
              o среднее арифметическое первых n членов прогрессии, 
              o сумма первых n членов прогрессии. 

        1 Арифметическая прогрессия задается значением первого ее члена и разницей, 
        так если первый член –  a 1, разница прогрессии – d, то a n = a 1 + (n – 1) * d). 
        */
        public class ArithmeticProgression
        {
            private double a1;
            private double d;
            public void SetArithmeticProgression(double a1, double d)
            {
                this.a1 = a1;
                this.d = d;
            }
            public void SetMemberFirst(double a1)
            {
                this.a1 = a1;
            }
            public void SetDifference(double d)
            {
                this.d = d;
            }
            public double GetMemberFirst()
            {
                return (this.a1);
            }
            public double GetDifference()
            {
                return (this.d);
            }
            public double GetMemberN(int n)
            {
                if (n <= 0)
                {
                    n = 1;
                }
                return (this.a1 + (n - 1) * this.d);
            }
            public double GetSumFirstMembersN(int n)
            {
                if (n <= 0)
                {
                    n = 1;
                }
                return (this.a1 + (n - 1) * this.d / 2) * n;
            }
            public double GetArithmeticMeanFirstMembersN(int n)
            {
                if (n <= 0)
                {
                    n = 1;
                }
                return GetSumFirstMembersN(n) / n;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
