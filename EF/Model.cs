using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class EshopContext : DbContext
{

    public DbSet<Product> ProductTable { get; set; }

    

    public EshopContext()
    {
      
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=./db.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Product>()
        .Property(p => p.Id)
        .ValueGeneratedOnAdd();
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

