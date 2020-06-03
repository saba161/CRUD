using ExamplesJs.Tasks.TaskEighteen;
using ExamplesJs.Tasks.TaskEighteen.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamplesJs.Execute
{
    public class ExecuteTaskEighteen
    {
        public static long Execute()
        {
            List<Boxart> list = new List<Boxart>
            {
                new Boxart
                {
                    Height = 200,
                    Width = 200,
                    Url = "1"
                },

                new Boxart
                {
                    Height = 150,
                    Width = 200,
                    Url = "2"
                },

                new Boxart
                {
                    Height = 350,
                    Width = 400,
                    Url = "2"
                }
            };

            return LargestBoxartReduceAndMap.LargestBoxart(list);
        }
    }
}
