using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }
        public SQLContext(DbContextOptions<SQLContext> options) 
            : base(options) { }
        
        //存到数据库
        public DbSet<User> _users { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Suggest> Suggests { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        //定位数据库的地址
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=First;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();
         

        }
    }
}
