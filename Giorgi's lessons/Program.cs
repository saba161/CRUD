using Giorgi_s_lessons.Class;
using Giorgi_s_lessons.Test;
using System;
using static System.Console;

namespace Giorgi_s_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(1, BinaryNumber.Pow(2, BinaryNumber.Binary(0)));
            Assert.AreEqual(4, BinaryNumber.Pow(2, BinaryNumber.Binary(2)));
            Assert.AreEqual(8, BinaryNumber.Pow(2, BinaryNumber.Binary(3)));
            Assert.AreEqual(16, BinaryNumber.Pow(2, BinaryNumber.Binary(4)));
            Assert.AreEqual(32, BinaryNumber.Pow(2, BinaryNumber.Binary(5)));
            Assert.AreEqual(64, BinaryNumber.Pow(2, BinaryNumber.Binary(6)));
            Assert.AreEqual(128, BinaryNumber.Pow(2, BinaryNumber.Binary(7)));
            Assert.AreEqual(256, BinaryNumber.Pow(2, BinaryNumber.Binary(8)));
            Assert.AreEqual(512, BinaryNumber.Pow(2, BinaryNumber.Binary(9)));
        }
    }
}
