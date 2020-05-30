using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tree.Models;

namespace Tree.Domain.Person1.Commands
{
    public class CreateShop : Command<Person>
    {
        private readonly int personId;
        private readonly string shopName;

        public CreateShop(int personId, string shopName)
        {
            this.personId = personId;
            this.shopName = shopName;
        }

        public Repository<Person> Run(Repository<Person> ag)
        {
            var person = ag.Get(personId);
            var newShop = new Shop()
            {
                Name = shopName
            };

            person.Shops.Add(newShop);

            ag.Entry(newShop, EntityState.Added);

            return ag;
        }
    }
}
