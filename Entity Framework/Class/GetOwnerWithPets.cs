using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Entity_Framework.Class
{
    public class GetOwnerWithPets
    {
        private readonly int id;

        public GetOwnerWithPets(int id)
        {
            this.id = id;
        }

        public IQueryable<Owners> GetOwnerWithYourPets()
        {
            using (DataContext context = new DataContext())
            {
                //var ownerWithPets = context.owners.Where(x => x.id == id).FirstOrDefault();

                var ownerWithPets = from s in context.owners
                                    join s1 in context.pets on s.Ownersid equals s1.Id
                                    select s;


                return ownerWithPets;
            }
        }

    }
}
