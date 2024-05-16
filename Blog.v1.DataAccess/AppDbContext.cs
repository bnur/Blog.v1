using Blog.v1.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Contents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            {
                modelBuilder.Entity<Category>()
                    .HasMany(e => e.Articles)
                    .WithOne(e => e.Category)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();
            }

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "AI"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Web"
                });

            modelBuilder.Entity<Article>().HasData(
                new Article()
                {
                    Id = 1,
                    Name = "Web Subject1",
                    Content = "Web content deneme 1",
                    Title = "Web Content Title 1",
                    CategoryId = 2
                },
                new Article()
                {
                    Id = 2,
                    Name = "Web Subject2",
                    Content = "Web content deneme 2",
                    Title = "Web Content Title 2",
                    CategoryId = 2
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User() 
                { 
                    Id = 1,
                    UserName = "admin",
                    Password = "1234",
                    Email = "bnurdursun@gmail.com",
                    FirstName = "Admin",
                    LastName = "adm",
                    IsActive = true,
                    PhoneNumber = "1234567890",
                    Name = "adm"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
