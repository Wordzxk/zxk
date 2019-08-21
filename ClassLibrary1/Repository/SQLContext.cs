using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorys
{
    
    public class SQLContext : DbContext
    {
        
        //定位数据库的地址
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=DbContext;Integrated Security=True;";
            optionsBuilder
                //.UseLoggerFactory(consoleLoggFactory)
                .UseSqlServer(connectionString);
       
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();
            //引用异常
            modelBuilder.Entity<Emails>()
                .HasOne(e => e.Owner)
                .WithOne(u => u.Emails)
                .HasForeignKey<Emails>(e => e.OwnerId);

            modelBuilder.Entity<BlogToKeywords>()
                .HasKey(bk => new { bk.BlogId, bk.KeywordId });

            modelBuilder.Entity<Article>()
                .HasDiscriminator(b => b.DiscrimintorTybe);

            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Posts)
                .WithOne(p => p.Blog)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Suggest>();
        }
    }

    public class BlogToKeywords
    {
       
        public int BlogId { get; set; }
        public int KeywordId { get;  set; }
    }
}
