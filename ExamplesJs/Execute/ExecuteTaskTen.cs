using ExamplesJs.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskTen
    {
        public static IEnumerable<string> Execute()
        {
            List<string[]> list = new List<string[]>
            {
                new string [] { "1a", "2b", "3c" },
                new string [] { "4d", "5e", "6f" },
                new string [] { "7g", "8h", "9j" }
            };

            var result = list.ConcatAll();

            return result;
        }
    }
}
