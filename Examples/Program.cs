using Examples.Crud;
using System;
using System.Data;
using System.Data.SqlClient;
using Xceed.Wpf.Toolkit;
using static System.Console;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1) Type R - Read Record  2) Type C - Creat Reccord  3) Type U - Update Record 4) Type D - Detelete Record");
            var command = Console.ReadLine();

            if (command == "C")
            {
                WriteLine("Enter Name:");
                var firstName = ReadLine();

                WriteLine("Enter LastName:");
                var lastName = ReadLine();

                WriteLine("Enter phoneNumber:");
                var phoneNumber = Int64.Parse(ReadLine());

                var returnedWord = new Create(firstName, lastName, phoneNumber).Execute();

                WriteLine(returnedWord);
            }

            if (command == "D")
            {
                WriteLine("Enter Id");
                var id = Int32.Parse(ReadLine());

                var returnRecord = new Delete(id).Remove();
            }

            if (command == "U")
            {
                WriteLine("Enter User Id:");
                var userId = Int32.Parse(ReadLine());

                WriteLine("Enter Name:");
                var firstName = ReadLine();

                WriteLine("Enter LastName:");
                var lastName = ReadLine();

                WriteLine("Enter phoneNumber:");
                var phoneNumber = Int64.Parse(ReadLine());

                var returnedWord = new Update(userId, firstName, lastName, phoneNumber).UpdateRecord();

                WriteLine(returnedWord);
            }

            if (command == "R")
            {
                WriteLine("Enter User Id:");
                var userId = Int32.Parse(ReadLine());

                var records = new Read(userId).ReadRecord();
                foreach (var item in records)
                    WriteLine(item);
            }
        }
    }
}
