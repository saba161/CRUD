using System;
using System.Collections.Generic;
using System.Text;

namespace Giorgi_s_lessons.Class
{
    public class BinaryNumber
    {
        public static int Pow(int k)
        {
            int sum = 1;

            for (int i = 1; i <= k; i++)
            {
                sum = sum * 2;
            }

            return sum;
        }

        public static int Binary(int k)
        {
            var a = Pow(k);

            return a;
        }
    }
}
