using CrudWithJs.Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithJs.Dall
{
    public interface ICrud
    {
        University Create(University university);

        University Read(int id);

        University Update(University university);

        University Delete(int id);
    }
}
