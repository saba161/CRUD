using ExamplesJs.Class;
using ExamplesJs.Class.TaskThree.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using static ExamplesJs.Class.Task;
using ExamplesJs.Tasks.TaskSix.Models;
using ExamplesJs.Execute;
using ExamplesJs.Tasks.TaskFour;
using System.Linq;
using ExamplesJs.Tasks.TaskSeven;

namespace ExamplesJs
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"C:\Users\sabak\OneDrive\Рабочий стол\CRUD\ExamplesJs\Jsons\newReleases.json";


            //Task Three
            var taskThree = ExecuteTaskThree.Execute(
                LoadJson(jsonFilePath)
                );

            foreach (var item in taskThree)
            {
                WriteLine($"Id is :{item.Id}, Title is : {item.Title}");
            }

            //Task Four , Exentention method
            List<int> list = new List<int> { 1, 2, 3 };

            var newList = list.Map(x => x + 1);

            foreach (var item in newList)
            {
                WriteLine(item);
            }

            //Task Six
            var taskSeven = ExecuteTaskSix.Execute();

            foreach (var item in taskSeven)
            {
                WriteLine($"Id is :{item.Id}, Rating is : {item.Rating}");
            }

            //Task Seven
            List<int> filterList = new List<int> { 1, 2, 3, 4, 5, 0 };

            var result = filterList.Filter(x => x > 2);

            foreach (var item in result)
            {
                WriteLine(item);
            }
        }
    }
}



