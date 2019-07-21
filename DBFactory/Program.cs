using BLL.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new SQLContext().Database.Migrate();
            RegisterFactory.Create();
            Suggest.NewFactory.Create();
        }
    }
}
