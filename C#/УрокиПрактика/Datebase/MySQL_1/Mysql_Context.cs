using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace MySQL_1
{
    class Mysql_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=192.168.126.246;UserId=boettcher;Password=$Init0101$;database=Users;");
        }
        public DbSet<User> Users { get; set; }
    }
}
