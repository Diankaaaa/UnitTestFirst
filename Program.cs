using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static double Sin2(double x)
        {
            const double eps = 1e-15;  // погрешность вычислений
            double s = 0;  // начальная сумма
            double r = x;   // первый член ряда
            int n = 1;         // показатель степени
            while (Math.Abs(r) > eps) // условие выполнения цикла
            {
                s = s + r;      // добавление члена ряда
                n = n + 2;  // наращивание  n:  1,3,5,7,...
                r = -r * x * x / (n * (n - 1)); // новый член ряда
            }
            return s;       // возврат результата
        }

        public static double sh(double x)
        {
            const double eps = 1e-15;
            double s = 0;
            double r = x;
            int n = 1;
            while (Math.Abs(r) > eps)
            {
                s = s + r;
                n = n + 2;
                r = r * x * x / (n * (n - 1));
            }
            return s;

        }
    }
}
