using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialLibrary
{
    /*Задание 2 
    Разработать класс «многочлен» для работы с многочленами от одной переменной 
    и перегрузить для класса операции, допустимые для работы с многочленами(сложение, вычитание, умножение). 
    В классе определить свойства(например, степень многочлена), индексатор на чтение и запись
    (доступ к коэффициенту по индексустепени), метод, возвращающий строковое представление значения многочлена 
    в удобном для восприятия виде, например, «5х^3 + 2x^2 + 45»1.  
    Класс скомпилировать в динамическую библиотеку.В консольном приложении продемонстрировать работу созданного класса.

    1 Как правило, для этой цели перегружается метод ToString()
    */
    public class Polynomial
    {
        private int[] members;
        private int degree;
        public Polynomial()
        {
            members = new int[1];

        }
        public Polynomial(int degree)
        {
            members = new int[degree];
            this.degree = degree;
        }
        public void SetDegree(int degree)
        {
            this.degree = degree;
        }
        public int GetDegree()
        {
            return this.degree;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = GetDegree() - 1; i >= 0; i--)
            {
                string coeff = "";
                if (members[i] != 1 & members[i] != -1)
                {
                    coeff += "" + members[i];
                }
                if (i >= 2)
                {
                    str += ((members[i] == 0 ? "" : (members[i] < 0 ? "" : "+") + coeff + "x^" + i));
                }
                else if (i == 1)
                {
                    str += ((members[i] == 0 ? "" : (members[i] < 0 ? "" : "+") + coeff + "x"));
                }
                else if (i == 0)
                {
                    str += ((members[i] == 0 ? "" : (members[i] < 0 ? "" : "+") + members[i]));
                }
            }
            if (str.IndexOf('+') == 0)
            {
                str = str.Substring(1);
            }
            return str;
        }
        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            int degree1 = polynomial1.degree;
            int degree2 = polynomial2.degree;
            int degree3 = degree1 > degree2 ? degree1 : degree2;
            Polynomial polynomial3 = new Polynomial(degree: degree3);
            for (int i = degree3 - 1; i >= 0; i--)
            {
                if (i >= degree2)
                {
                    polynomial3[i] = polynomial1[i];
                }
                else if (i >= degree1)
                {
                    polynomial3[i] = polynomial2[i];
                }
                else
                {
                    polynomial3[i] = polynomial1[i] + polynomial2[i];
                }
            }
            return polynomial3;
        }
        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            int degree1 = polynomial1.degree;
            int degree2 = polynomial2.degree;
            int degree3 = degree1 > degree2 ? degree1 : degree2;
            Polynomial polynomial3 = new Polynomial(degree: degree3);
            for (int i = degree3 - 1; i >= 0; i--)
            {
                if (i >= degree2)
                {
                    polynomial3[i] = polynomial1[i];
                }
                else if (i >= degree1)
                {
                    polynomial3[i] = polynomial2[i];
                }
                else
                {
                    polynomial3[i] = polynomial1[i] - polynomial2[i];
                }
            }
            return polynomial3;
        }
        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            int degree1 = polynomial1.degree;
            int degree2 = polynomial2.degree;
            int degree3 = degree1 + degree2 - 1;
            Polynomial polynomial3 = new Polynomial(degree: degree3);
            for (int i = degree1 - 1; i >= 0; i--)
            {
                for (int j = degree2 - 1; j >= 0; j--)
                {
                    polynomial3[i + j] += polynomial1[i] * polynomial2[j];
                }
            }
            return polynomial3;
        }
        public int this[int index]
        {
            set
            {
                members[index] = value;
            }

            get
            {
                return members[index];
            }
        }
    }
}
