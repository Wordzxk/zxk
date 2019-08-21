using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace New_Wait
{
    public class SQLContext :DbContext
    {
        
      /*暂时无用
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                @"Data Source = (localdb)\ProjectsV13;Initial Catalog = Wait; Integrated Security = True;";
                optionsBuilder.UseSqlServer(connectionString);
        }
        */

    }

}
