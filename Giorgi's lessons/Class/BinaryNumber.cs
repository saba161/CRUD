using System;
using System.Collections.Generic;
using System.Text;

namespace Giorgi_s_lessons.Class
{
    public class BinaryNumber
    {
        public static int Pow(int k, int n)
        {
            int sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = sum * k;
            }

            return sum;
        }

        public static int Binary(int k)
        {
            var a = Pow(2, k);

            return a;
        }
    }
}
