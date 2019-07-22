using System;
using System.Collections.Generic;
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

        public Suggest Save(Suggest suggest)
        {
            _sqLContext.Suggests.Add(suggest);
            //_sqLContext.SaveChanges();
            return suggest;
        }
    }
}
