
using BLL;
using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using System;

namespace Factory
{
    class Program
    {
        public static void Main(string[] ages)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();
            db.EnsureCreated();

            RegisterFactory.Create();

        }

    }
}
