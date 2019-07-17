
using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Factory
{
    class Program
    {
        public static void Main(string[] ages)
        {
            new UserRepository().Database.Migrate();
            Console.WriteLine("测试");
        }

    }
}
