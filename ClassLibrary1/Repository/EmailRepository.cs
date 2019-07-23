using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
    public class EmailRepository :Repository<Email>
    {
       //public DbSet<Email> Entities { get; set; }
        //得到Email
        public Email GetEmailById(int id)
        {
            return entities.Where(e => e.Id == id).SingleOrDefault();

        }
    }
}
