using CrudWithJs.Models;
using CrudWithJs.Views.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CrudWithJs.Dall
{
    public class Crud : ICrud
    {
        private readonly AppDbContext _context;

        public Crud(AppDbContext context)
        {
            _context = context;
        }

        public University Create(University university)
        {
            _context.Universities.Add(
               new University
               {
                   id = university.id,
                   UniversityName = university.UniversityName
               }
           );

            _context.SaveChanges();

            return university;
        }

        public University Delete(int id)
        {
            var deleteRecord = _context.Universities.Where(x => x.id == id).FirstOrDefault();

            _context.Remove(deleteRecord);
            _context.SaveChanges();

            var itemList = new University
            {
                id = deleteRecord.id,
                UniversityName = deleteRecord.UniversityName
            };

            return itemList;
        }

        public University Read(int id)
        {
            var read = _context.Universities.Where(x => x.id == id).FirstOrDefault();

            return read;
        }

        public University Update(University university)
        {
            var update = _context.Universities.Where(x => x.id == university.id).FirstOrDefault();

            update.UniversityName = university.UniversityName;

            _context.SaveChanges();

            var itemList = new University
            {
                id = update.id,
                UniversityName = update.UniversityName
            };

            return itemList;

        }
    }
}
