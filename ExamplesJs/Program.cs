using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using static ExamplesJs.Class.Task;
using ExamplesJs.Execute;
using System.Linq;
using ExamplesJs.Tasks.TaskEleven.Models;
using ExamplesJs.Tasks.TaskEleven;
using ExamplesJs.Extentions;
using ExamplesJs.Tasks.TaskSixsitReduce;

namespace ExamplesJs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string jsonFilePath = @"C:\Users\sabak\OneDrive\Рабочий стол\CRUD\ExamplesJs\Jsons\newReleases.json";

            ////Task Three
            //var taskThree = ExecuteTaskThree.Execute(
            //    LoadJson(jsonFilePath)
            //    );

            //foreach (var item in taskThree)
            //{
            //    WriteLine($"Id is :{item.Id}, Title is : {item.Title}");
            //}

            //*********************************************************************************************************************************

            ////Task Four , Exentention method
            //List<int> list = new List<int> { 1, 2, 3 };

            //var newList = list.Map(x => x + 1);

            //foreach (var item in newList)
            //{
            //    WriteLine(item);
            //}

            //*********************************************************************************************************************************

            ////Task Five

            //var resultTaskFive = ExecuteTaskFive.Execute();

            //foreach (var item in resultTaskFive)
            //{
            //    WriteLine($"Id: {item.Item1}, Title: {item.Item2}");
            //}

            //*********************************************************************************************************************************

            ////Task Six
            //var taskSeven = ExecuteTaskSix.Execute();

            //foreach (var item in taskSeven)
            //{
            //    WriteLine($"Id is :{item.Id}, Rating is : {item.Rating}");
            //}

            //*********************************************************************************************************************************

            ////Task Seven
            //List<int> filterList = new List<int> { 1, 2, 3, 4, 5, 0 };

            //var result = filterList.Filter(x => x > 2);

            //foreach (var item in result)
            //{
            //    WriteLine(item);
            //}

            //*********************************************************************************************************************************

            ////Task Nine
            //var resultTaskNine = ExecuteTaskNine.Execute();

            //foreach (var item in resultTaskNine)
            //{
            //    WriteLine(item.Id);
            //}

            //*********************************************************************************************************************************

            ////Task Ten

            //var resultTaskTen = ExecuteTaskTen.Execute();

            //foreach (var item in resultTaskTen)
            //{
            //    WriteLine(item);
            //}

            //*********************************************************************************************************************************

            ////Task Eleven
            //var resultTaskEleven = ExecuteTaskEleven.Execute();

            //foreach (var item in resultTaskEleven)
            //{
            //    WriteLine(item);
            //}

            //*********************************************************************************************************************************

            ////Task Twelve
            //var taskTwelve = ExecuteTaskTwelve.Execute();

            //foreach (var item in taskTwelve)
            //{
            //    WriteLine(item.Height);
            //}

            //*********************************************************************************************************************************

            //Task Sixstin

            //WriteLine(ExecuteTaskSixstinReduce.Execute());

            ////Test
            //List<int> tin = new List<int> { 4, 2, 3 };

            //WriteLine(tin.Reduce((x, y) => x * y) == 24);
            //WriteLine(tin.Reduce((x, y) => x + y) == 9);
            //WriteLine(tin.Reduce((x, y) => x - y) == -1);

            //*********************************************************************************************************************************

            //Task Eghtin
            WriteLine(ExecuteTaskEighteen.Execute());
            
            //********************************************************************************************************************************
            
            //მეორენაირი Reduce
            var filterWithReduce = ReduceLargest.FilterWithReduce();

            List<int> filtered = new List<int> { 2, 4, 6 };

            WriteLine(filterWithReduce.SequenceEqual(filtered));
        }
    }
}