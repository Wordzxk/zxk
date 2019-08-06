
using BLL;
using BLL.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using System;

namespace Factory
{
    class Program
    {
         static void Main(string[] ages)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();
            db.EnsureCreated();

            RegisterFactory.Create();
            Blog.NewFactory.Create();


            Console.Read();
        }

    }
}
