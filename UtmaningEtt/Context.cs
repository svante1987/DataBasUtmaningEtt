using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;

namespace UtmaningEtt
{
    class Context : DbContext
    {
    public DbSet<Platform>Platforms { get; set; }

        public DbSet<Game> Games{ get; set; }

        public DbSet<Publisher> Publishers { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"server=.\sqlexpress;" +
                "Database=UtmaningEtt;" +
                "trusted_connection = true;");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
