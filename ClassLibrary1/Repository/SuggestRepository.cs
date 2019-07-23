using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class SuggestRepository 
    {
        private SQLContext _sqLContext;
        public SuggestRepository()
        {


            _sqLContext = new SQLContext();
        }


        public Suggest Save(Suggest suggest, int authorId)
        {
            suggest.Author = _sqLContext._users
                .Where(u => u.Id == authorId)
                .SingleOrDefault();

            _sqLContext.Suggests.Add(suggest);
            _sqLContext.SaveChanges();
            return suggest;
        }
    }
}
