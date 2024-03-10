using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FavoriteBook> FavoriteBook { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Test1> Tests { get; set; }

        protected override void OnConfiguring
           (DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer
                (@"Data Source=DESKTOP-SNL91V1;Initial Catalog=LibraryDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }
    }
}

