using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity_Framework.Class
{
    public class Update
    {
        private readonly string name;
        private readonly string sex;
        private readonly int age;
        private readonly int id;

        public Update(int id, string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.id = id;
        }

        public string UpdateRecord()
        {
            using (DataContext context = new DataContext())
            {
                var recordForUpdate = context.pets.Where(x => x.Id == id).FirstOrDefault();

                recordForUpdate.Name = name;
                recordForUpdate.Sex = sex;
                recordForUpdate.Age = age;

                context.SaveChanges();
            }
            return "Updated";
        }
    }
}
