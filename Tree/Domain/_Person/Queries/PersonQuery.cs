using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tree.Models;

namespace Tree.Class
{

    public class PersonQuery : Query<Person>
    {
        public readonly int personId;

        public PersonQuery(int personId)
        {
            this.personId = personId;
        }

        public Person Read()
        {
            using (var context = new TreeDbContext())
            {
                var allRecord = 
                    context
                    .Persons
                    .Include(x => x.Shops)
                        .ThenInclude(x => x.Products)
                    .Where(x => x.Id == personId)
                    .FirstOrDefault();

                return allRecord;
            }
        }
    }
}
