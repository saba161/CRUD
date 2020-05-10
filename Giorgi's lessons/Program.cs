using Giorgi_s_lessons.Class;
using Giorgi_s_lessons.Test;
using System;
using static Giorgi_s_lessons.Class.BinaryNumber;
using static System.Console;

namespace Giorgi_s_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(1, Binary(0));
            Assert.AreEqual(4, Binary(2));
            Assert.AreEqual(8, Binary(3));
            Assert.AreEqual(16, Binary(4));
            Assert.AreEqual(32, Binary(5));
            Assert.AreEqual(64, Binary(6));
            Assert.AreEqual(128, Binary(7));
            Assert.AreEqual(256, Binary(8));
            Assert.AreEqual(512, Binary(9));
        }
    }
}
