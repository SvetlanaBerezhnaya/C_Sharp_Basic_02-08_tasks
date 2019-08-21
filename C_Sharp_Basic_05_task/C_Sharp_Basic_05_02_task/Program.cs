using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolynomialLibrary;

namespace PolynomialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            Polynomial polynomial1 = new Polynomial(degree: 2);

            // The polynomial1 initialization:
            for (int i = 0; i < polynomial1.GetDegree(); i++)
            {
                polynomial1[i] = ran.Next(1, 10);
                Console.Write("{0}\t", polynomial1[i]);
            }
            Console.WriteLine(polynomial1);

            Polynomial polynomial2 = new Polynomial(degree: 2);

            // The polynomial2 initialization:
            for (int i = 0; i < polynomial2.GetDegree(); i++)
            {
                polynomial2[i] = ran.Next(1, 10);
                Console.Write("{0}\t", polynomial2[i]);
            }
            Console.WriteLine(polynomial2);

            Polynomial polynomial3 = new Polynomial();
            polynomial3 = polynomial1 * polynomial2;
            for (int i = 0; i < polynomial3.GetDegree(); i++)
            {
                Console.Write("{0}\t", polynomial3[i]);
            }
            Console.WriteLine(polynomial3);

            polynomial3 = polynomial1 + polynomial2;
            for (int i = 0; i < polynomial3.GetDegree(); i++)
            {
                Console.Write("{0}\t", polynomial3[i]);
            }
            Console.WriteLine(polynomial3);

            polynomial3 = polynomial1 - polynomial2;
            for (int i = 0; i < polynomial3.GetDegree(); i++)
            {
                Console.Write("{0}\t", polynomial3[i]);
            }
            Console.WriteLine(polynomial3);
            Console.ReadLine();
        }
    }
}
