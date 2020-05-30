using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using Tree.Class;
using Tree.Domain.Person1.Commands;
using Tree.Models;

namespace Tree
{

    public class CommandHandler<E>
    {
        private readonly Repository<E> repo;

        public CommandHandler(Repository<E> repo)
        {
            this.repo = repo;
        }

        public void Handle(Command<E> cmd)
        {
            var nextState = cmd.Run(repo);
            repo.Store();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personCommandHandler = new CommandHandler<Person>(
                new PersonRepository(
                    new TreeDbContext()
                    )
                );

            personCommandHandler.Handle(new CreateShop(1, "Apple Store 3"));

            List<int> n = new List<int> { 2, 3, 4 };

            var p = S(n);
        }

        public static IEnumerator<int> S(List<int> n)
        {
            var s = n.GetEnumerator();

            while (s.MoveNext())
            {
                yield return s.Current;
            }
        }

    }
}
