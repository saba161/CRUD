using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Giorgi_s_lessons.Test
{
    public class Assert
    {
        public static void AreEqual(string excepted, string actual)
        {
            if (excepted == actual)
            {
                WriteLine(@$"Result: {true}
Excepted: {excepted}
Actual: {actual}  
                ");
            }
            else
            {
                WriteLine(@$"Result: {false}
Excepted: {excepted}
Actual: {actual} 
                ");
            }
        }

        public static void AreEqual(int excepted, int actual)
        {
            AreEqual(excepted.ToString(), actual.ToString());
        }

    }
}
