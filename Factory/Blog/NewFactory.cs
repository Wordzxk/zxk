using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Suggest
{
   internal class NewFactory
    {
        public static readonly LoggerFactory consoleLoggerFactory
            = new LoggerFactory(
                new[]
                {
                    new  ConsoleLoggerProvider((categroy,level) => true, true)
                });


        internal static void Create()
        {

            string connectionString =
                @"Data Source=(localdb)\ProjectsV13;Initial Catalog=First;Integrated Security=True;";
            DbContextOptionsBuilder<SQLContext> optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            optionsBuilder
                .UseLoggerFactory(consoleLoggerFactory)
                .UseSqlServer(connectionString);
        }

        
    }
}
