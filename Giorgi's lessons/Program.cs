using static Giorgi_s_lessons.Class.BinaryNumber;
using static Giorgi_s_lessons.Test.Assert;
using static System.Console;

namespace Giorgi_s_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            AreEqual(1, Binary(0));
            AreEqual(4, Binary(2));
            AreEqual(8, Binary(3));
            AreEqual(16, Binary(4));
            AreEqual(32, Binary(5));
            AreEqual(64, Binary(6));
            AreEqual(128, Binary(7));
            AreEqual(256, Binary(8));
            AreEqual(512, Binary(9));
        }
    }
}
