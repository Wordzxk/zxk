using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
    public class EmailRepository :Repository<Emails>
    {
       
        //得到Email
        public Emails GetEmailById(int id)
        {
            return entities.Where(e => e.Id == id).SingleOrDefault();

        }
    }
}
