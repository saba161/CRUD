using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity_Framework.Class
{
    public class GetRecord
    {
        private readonly int id;

        public GetRecord(int id)
        {
            this.id = id;
        }

        public Pets GetRecordById()
        {
            using (DataContext context = new DataContext())
            {
                var pet = context.pets.Where(x => x.Id == id).FirstOrDefault();

                return pet;
            }
        }
    }
}
