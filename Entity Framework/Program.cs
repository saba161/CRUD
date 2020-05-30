using Entity_Framework.Class;
using System;
using static System.Console;

namespace Entity_Framework
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
                var name = ReadLine();

                WriteLine("Enter Sex:");
                var sex = ReadLine();

                WriteLine("Enter Age:");
                var age = Int32.Parse(ReadLine());

                var returnedWord = new Create(name, sex, age).AddNewRecord();

                WriteLine(returnedWord);
            }

            if (command == "D")
            {
                WriteLine("Enter Id");
                var id = Int32.Parse(ReadLine());

                var returnRecord = new Delete(id).Remove();

                WriteLine(returnRecord);
            }

            if (command == "U")
            {
                WriteLine("Enter Id");
                var id = Int32.Parse(ReadLine());

                WriteLine("Enter Name:");
                var name = ReadLine();

                WriteLine("Enter Sex:");
                var sex = ReadLine();

                WriteLine("Enter Age:");
                var age = Int32.Parse(ReadLine());

                var returRecord = new Update(id, name, sex, age).UpdateRecord();

                WriteLine(returRecord);
            }

            if (command == "GetRecordById")
            {
                WriteLine("Enter Id");
                var id = Int32.Parse(ReadLine());

                var record = new GetRecord(id).GetRecordById();

                WriteLine(@$"Name: {record.Name} 
Sex: {record.Sex}
Age: {record.Age}");
            }

            if (command == "GetOwnerById")
            {
                WriteLine("Enter Id");
                var id = Int32.Parse(ReadLine());

                var record = new GetOwnerWithPets(id).GetOwnerWithYourPets();
            }
        }
    }
}
