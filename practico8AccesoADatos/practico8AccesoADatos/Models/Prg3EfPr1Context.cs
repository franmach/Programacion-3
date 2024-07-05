using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace practico8AccesoADatos.Models;

public partial class Prg3EfPr1Context : DbContext
{
    public Prg3EfPr1Context()
    {
    }

    public Prg3EfPr1Context(DbContextOptions<Prg3EfPr1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Alquilere> Alquileres { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Copia> Copias { get; set; }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=FRANCISCOMACHAD ;Initial Catalog=PRG3_EF_PR1;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alquilere>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alquiler__3214EC073ACBF7EF");

            entity.Property(e => e.FechaAlquiler).HasColumnType("datetime");
            entity.Property(e => e.FechaEntregada).HasColumnType("datetime");
            entity.Property(e => e.FechaTope).HasColumnType("datetime");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Alquileres)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkAlquileresClientes");

            entity.HasOne(d => d.IdCopiaNavigation).WithMany(p => p.Alquileres)
                .HasForeignKey(d => d.IdCopia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkAlquileresCopias");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC0736876518");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Copia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Copias__3214EC074F6A7C96");

            entity.Property(e => e.Formato)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPeliculaNavigation).WithMany(p => p.Copia)
                .HasForeignKey(d => d.IdPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkCopiasPeliculas");
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pelicula__3214EC073E221236");

            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
