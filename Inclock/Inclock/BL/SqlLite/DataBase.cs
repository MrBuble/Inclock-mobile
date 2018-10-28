using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Inclock.BL.SqlLite
{
    public class DataBase : DbContext
    {
        public DbSet<User> Users { get; set; }
        private string _ConnectionString;
        public DataBase(string connectionString)
        {
            _ConnectionString = Path.Combine(connectionString, "mwd.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_ConnectionString}");
        }
    }
}
