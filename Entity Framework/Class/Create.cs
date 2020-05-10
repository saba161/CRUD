using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.Class
{
    public class Create
    {
        private readonly string name;

        private readonly string sex;

        private readonly int age;

        public Create(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public string AddNewRecord()
        {
            using (DataContext context = new DataContext())
            {
                context.pets.Add(
                    new Pets
                    {
                        Name = name,
                        Age = age,
                        Sex = sex
                    });
                context.SaveChanges();
            }

            return "Added";
        }
    }
}
