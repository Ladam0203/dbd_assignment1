using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFMigrations;

public class EshopContext : DbContext
{

    public DbSet<Product> ProductTable { get; set; }

    // The following configures EFMigrations to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=./db.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithOne(c => c.Product)
            .HasForeignKey<Product>(p => p.CategoryId);

        modelBuilder.Entity<Category>()
            .Property(p => p.Id)
            .ValueGeneratedOnAdd();
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}