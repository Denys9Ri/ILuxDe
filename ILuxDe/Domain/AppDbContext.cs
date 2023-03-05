using ILuxDe.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ILuxDe.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "59513001-3822-46f5-ad89-5ae08b333089",
                Name = "admin",
                NormalizedName = "ADMIN"

            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3a967eae-964b-4601-9afc-af7c774dce53",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "mypost@email.com",
                NormalizedEmail = "MYPOST@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty

            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2d99ba7d-a621-48aa-9dcf-74dfa2184bb2",
                UserId = "8720e193-0588-464b-8e4f-a1200f078f29"

            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5ac71730-50e1-41c0-bbd7-8bd11d9082ba"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("6e179b96-cce7-461f-9438-bdfec46b316a"),
                CodeWord = "PageServices",
                Title = "Услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("410230a9-2ce0-4496-9ec6-756c42e35b5f"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
