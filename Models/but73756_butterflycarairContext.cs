using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ButterflyCarair.Models
{
    public partial class but73756_butterflycarairContext : IdentityDbContext<User>
    {
        public but73756_butterflycarairContext()
        {
        }

        public but73756_butterflycarairContext(DbContextOptions<but73756_butterflycarairContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Scent> Scents { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<New> News { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=112.78.2.154;Database=but73756_butterflycarair;user=but73756_but73756;password=Quyet1702@;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("but73756_but73756");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Avatar).HasMaxLength(300);

                entity.Property(e => e.Concentration).HasMaxLength(100);

                entity.Property(e => e.Image1).HasMaxLength(200);

                entity.Property(e => e.Image2).HasMaxLength(200);

                entity.Property(e => e.Image3).HasMaxLength(200);

                entity.Property(e => e.Image4).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.Origin).HasMaxLength(100);

                entity.Property(e => e.PerfumeType).HasMaxLength(100);

                entity.Property(e => e.ProductType).HasMaxLength(300);

                entity.Property(e => e.ReleaseYear).HasMaxLength(100);

                entity.Property(e => e.Sex).HasMaxLength(30);

                entity.Property(e => e.Style).HasMaxLength(100);

                entity.Property(e => e.Trademark).HasMaxLength(100);

            });

            modelBuilder.Entity<Scent>(entity =>
            {
                entity.ToTable("Scent");

                entity.Property(e => e.ScentName).HasMaxLength(200);

                entity.Property(e => e.ProductCode).HasMaxLength(50);
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Scents)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Scent");
            });
             modelBuilder.Entity<New>(entity =>
            {
                entity.ToTable("News");

                entity.Property(e => e.Avatar).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
                entity.Property(e => e.CreateDate).HasColumnType("datetime");
                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
