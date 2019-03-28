using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Models.Map;

namespace Models
{
    public class DatabaseContext : DbContext
    {
        protected const string ConfigurationConnection = @"Server=.\SQLExpress;Database=DataBaseCode;User Id=sa;Password=senha;MultipleActiveResultSets=true;";
        
        public DbSet<People> People {get;set;}
        public DbSet<Book> Book {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {            
            modelBuilder.ApplyConfiguration(new PeopleMap());
            modelBuilder.ApplyConfiguration(new BookMap());
        }
    }
}