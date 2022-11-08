using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.DataConnection
{
    public class DataContext : DbContext
    {
        public DbSet<TStudent> DBstudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source =. ; initial Catalog = CRUD ; integrated Security = true ;");
        }
    }
}
