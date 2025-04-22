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

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Episode> Episodes { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Moviecast> Moviecasts { get; set; }

    public virtual DbSet<Series> Series { get; set; }

    public virtual DbSet<Thumbnail> Thumbnails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Actorid).HasName("actors_pkey");

            entity.ToTable("actors");

            entity.Property(e => e.Actorid).HasColumnName("actorid");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Picture)
                .HasMaxLength(100)
                .HasColumnName("picture");
        });

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

        modelBuilder.Entity<Moviecast>(entity =>
        {
            entity.HasKey(e => e.Moviecastid).HasName("moviecast_pkey");

            entity.ToTable("moviecast");

            entity.Property(e => e.Moviecastid).HasColumnName("moviecastid");
            entity.Property(e => e.Actorid).HasColumnName("actorid");
            entity.Property(e => e.Charactername)
                .HasMaxLength(100)
                .HasColumnName("charactername");
            entity.Property(e => e.Movieid).HasColumnName("movieid");

            entity.HasOne(d => d.Actor).WithMany(p => p.Moviecasts)
                .HasForeignKey(d => d.Actorid)
                .HasConstraintName("moviecast_actorid_fkey");

            entity.HasOne(d => d.Movie).WithMany(p => p.Moviecasts)
                .HasForeignKey(d => d.Movieid)
                .HasConstraintName("moviecast_movieid_fkey");
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

        modelBuilder.Entity<Thumbnail>(entity =>
        {
            entity.HasKey(e => e.Thumbid).HasName("thumbnails_pkey");

            entity.ToTable("thumbnails");

            entity.Property(e => e.Thumbid).HasColumnName("thumbid");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasColumnName("filename");
            entity.Property(e => e.Movieid).HasColumnName("movieid");

            entity.HasOne(d => d.Movie).WithMany(p => p.Thumbnails)
                .HasForeignKey(d => d.Movieid)
                .HasConstraintName("thumbnails_movieid_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
