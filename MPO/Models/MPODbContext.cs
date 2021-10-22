using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace MPO.Models
{


    public class MPODbContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post_Header> Post_Headers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


        { }


    }
}
