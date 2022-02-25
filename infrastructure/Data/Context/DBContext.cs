using System;
using infrastructure.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context
{
    public class context : DbContext
    {
        public DbSet<Category> categories { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("Data source =. ; initial Catalog = Sun; integrated Security = true ;");
        }
    }
}