using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp.Models
{
    public partial class snippetsContext : DbContext
    {
        public snippetsContext()
        {
        }

        public snippetsContext(DbContextOptions<snippetsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Snippets> Snippets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("DataSource=C:\\Plainoldprogrammer_dev\\osm\\db\\snippets.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("categories");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("DATETIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Snippets>(entity =>
            {
                entity.ToTable("snippets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("DATETIME")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Snippet).HasColumnName("snippet");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
