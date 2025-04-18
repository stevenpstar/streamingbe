using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StreamingBE.Models;

namespace StreamingBE.Data;

public partial class StreamingdevContext : DbContext
{
    public StreamingdevContext()
    {
    }

    public StreamingdevContext(DbContextOptions<StreamingdevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Episode> Episodes { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Episode>(entity =>
        {
            entity.HasKey(e => e.Episodeid).HasName("episodes_pkey");

            entity.ToTable("episodes");

            entity.Property(e => e.Episodeid).HasColumnName("episodeid");
            entity.Property(e => e.Seriesid).HasColumnName("seriesid");

            entity.HasOne(d => d.Series).WithMany(p => p.Episodes)
                .HasForeignKey(d => d.Seriesid)
                .HasConstraintName("episodes_seriesid_fkey");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Movieid).HasName("movies_pkey");

            entity.ToTable("movies");

            entity.Property(e => e.Movieid).HasColumnName("movieid");
            entity.Property(e => e.Filepath)
                .HasMaxLength(256)
                .HasColumnName("filepath");
            entity.Property(e => e.Filetype)
                .HasMaxLength(50)
                .HasColumnName("filetype");
            entity.Property(e => e.Poster)
                .HasMaxLength(256)
                .HasColumnName("poster");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Series>(entity =>
        {
            entity.HasKey(e => e.Seriesid).HasName("series_pkey");

            entity.ToTable("series");

            entity.Property(e => e.Seriesid).HasColumnName("seriesid");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
