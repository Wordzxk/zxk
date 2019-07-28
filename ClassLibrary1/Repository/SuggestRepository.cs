using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
    public class SuggestRepository :Repository<Suggest>
    {

        public Suggest Get(int id)
        {
            return entities.Where(u => u.Id == id).SingleOrDefault();
        }

    }
}
