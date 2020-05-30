using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tree.Models;

namespace Tree.Domain.Person1.Commands
{
    public class PersonRepository : Repository<Person>
    {
        private readonly TreeDbContext ctx;

        public PersonRepository(TreeDbContext ctx)
        {
            this.ctx = ctx;
        }

        public Person Get(int personId)
        {
            return ctx
                .Persons
                .Include(p => p.Shops)
                    .ThenInclude(s => s.Products)
                .Include(p => p.Zoos)
                    .ThenInclude(z => z.Animals)
                .First(p => p.Id == personId);
        }

        public void Entry(object p, EntityState state)
        {
            ctx.Entry(p).State = state;
        }

        public void Store()
        {
            ctx.SaveChanges();
        }
    }
}
