using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EjemploWebApi.Models;

public partial class BbContext : DbContext
{
    public BbContext()
    {
    }

    public BbContext(DbContextOptions<BbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Producto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC0751838F64");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
