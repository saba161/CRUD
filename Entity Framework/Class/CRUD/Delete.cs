using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity_Framework.Class
{
    public class Delete
    {
        private readonly int id;

        public Delete(int id)
        {
            this.id = id;
        }

        public string Remove()
        {
            using (DataContext context = new DataContext())
            {
                var petsForDelete = context.pets.Where(x => x.Id == id).FirstOrDefault();
                context.pets.Remove(petsForDelete);
                context.SaveChanges();
            }
            return "Deleted";
        }
    }
}
