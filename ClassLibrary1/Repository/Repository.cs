using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repositorys
{
    //Register的子类调用这个类
    public class Repository<T> where T : class
    {

        public Repository()
        {
            CurrentContext = new SQLContext();
            entities = CurrentContext.Set<T>();
        }
        public SQLContext CurrentContext { get; set; }
        protected DbSet<T> entities { get; set; }

        public void Flush()
        {
            CurrentContext.SaveChanges();
        }

        public T Save(T entitly)
        {
            entities.Add(entitly);
            //必须
            CurrentContext.SaveChanges();

            return entitly;
        }


    }
}
