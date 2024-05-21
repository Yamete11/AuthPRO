using AuthBE.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthBE.Context
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; }

        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(t =>
            {
                t.HasData(
                    new User { IdUser = 1, Name = "Gleb", Surname = "Ivanov", Password = "12345", Login = "admin"},
                    new User { IdUser = 2, Name = "Lena", Surname = "Mishchuk", Password = "123", Login = "admin1" });
            });
        }
    }
}
