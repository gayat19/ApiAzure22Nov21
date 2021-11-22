using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FirstAPI.Models
{
    public class HrContext : DbContext
    {
        public HrContext()
        {

        }
        public HrContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {

                    Id=101,
                    Name="Ramu",
                    Password="1234",
                    Role="User"
                },
                new User()
                {

                    Id = 102,
                    Name = "Somu",
                    Password = "1111",
                    Role = "Admin"
                }
                );
        }
    }
}
