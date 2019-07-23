using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorys
{
    [BindProperties]
    public class SQLContext<T> : DbContext where T : class
    {
        //public DbSet<T> Entities { get; set; }
        public static readonly LoggerFactory consoleLoggFactory
            = new LoggerFactory(
                new[]
                {
                    new ConsoleLoggerProvider((category,level) =>true, true)
                });

        public SQLContext()
        {

        }

        //定位数据库的地址
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=First;Integrated Security=True;";
            optionsBuilder
                .UseLoggerFactory(consoleLoggFactory)
                .UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();

            //modelBuilder.Entity<Email>()
            //    .HasOne(e => e.Owner)
            //    .WithOne(u => u.Email)
            //    .HasForignKey<Email>(e => e.OwnerId);

            modelBuilder.Entity<BlogToKeywords>()
                .HasKey(bk => new { bk.BlogId, bk.KeywordId });

            modelBuilder.Entity<Article>()
                .HasDiscriminator(b => b.DiscrimintorTybe);
        }
    }

    internal class BlogToKeywords
    {
        public object BlogId { get; internal set; }
        public object KeywordId { get; internal set; }
    }
}
