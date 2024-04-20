using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source= {databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DataBaseUser>().Property(e => e.id).ValueGeneratedOnAdd();

            var user = new DataBaseUser()
            {
                id = 1,
                Name = "John Wick",
                Password = "1234",
                Roles = UsersRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };
           
            var user2 = new DataBaseUser()
            {
                id = 2,
                Name = "Chuck Norris",
                Password = "123",
                Roles = UsersRolesEnum.INSPECTOR,
                Expires = DateTime.Now.AddYears(100)
            };
            modelBuilder.Entity<DataBaseUser>().HasData(user);
            modelBuilder.Entity<DataBaseUser>().HasData(user2);
        }
        public DbSet<DataBaseUser> Users { get; set; }
    }
}
