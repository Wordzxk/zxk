
using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace Factory
{
    class Program
    {
        public static void Main(string[] ages)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureCreated();       //如果存在数据库就删掉
            //db.EnsureCreated();     //可能会和Migrate冲突，不宜混合使用
            //db.Migrate();

            RegisterFactory.Create();
            Suggest.NewFactory.Create();
        }

    }
}
