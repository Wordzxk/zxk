﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BLL.Repositorys
{
    [BindProperties]
    public class UserRepository :Repository<User>
    {
        public UserRepository()
        {

        }

        //public DbSet<User> Entities { get; set; }
        //查询Name
        public User GetByName(string name)
        {
           
            return entities.Where(u => u.Name == name).SingleOrDefault();
        }
        //查询Id
        public User GetById(int id)
        {
            return entities.Where(u => u.Id == id).SingleOrDefault();
        }

        public void SetEntities(SQLContext currentContext)
        {
            return ;
        }
    }
}
