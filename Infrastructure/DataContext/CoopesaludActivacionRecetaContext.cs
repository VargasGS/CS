using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entiti;

public partial class CoopesaludActivacionRecetaContext : DbContext
{
    public CoopesaludActivacionRecetaContext()
    {
    }

    public CoopesaludActivacionRecetaContext(DbContextOptions<CoopesaludActivacionRecetaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivacionReceta> ActivacionReceta { get; set; }

    public virtual DbSet<EstadoReceta> EstadoReceta { get; set; }

    public virtual DbSet<LugarRetiro> LugarRetiro { get; set; }
    public virtual DbSet<LugarAtencion> LugarAtencion { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivacionReceta>(entity =>
        {
            entity.HasKey(e => e.IdReceta).HasName("PK__Activaci__3B54C73269EF2A46");

            entity.ToTable("ActivacionReceta");

            entity.Property(e => e.IdReceta).HasColumnName("IdReceta");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaAtencion)
                .HasColumnType("datetime")
                .HasColumnName("FechaAtencion");
            entity.Property(e => e.FechaRegistroComprobante)
                .HasColumnType("datetime")
                .HasColumnName("FechaRegistroComprobante");
            entity.Property(e => e.IdEstadoReceta).HasColumnName("IdEstadoReceta");
            entity.Property(e => e.IdLugarRetiro).HasColumnName("IdLugarRetiro");
            entity.Property(e => e.LugarReceta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LugarReceta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoRecetaNavigation).WithMany(p => p.ActivacionReceta)
                .HasForeignKey(d => d.IdEstadoReceta)
                .HasConstraintName("FK__Activacio__Id_Es__29572725");

            entity.HasOne(d => d.IdLugarRetiroNavigation).WithMany(p => p.ActivacionReceta)
                .HasForeignKey(d => d.IdLugarRetiro)
                .HasConstraintName("FK__Activacio__Id_Lu__286302EC");
        });

        modelBuilder.Entity<EstadoReceta>(entity =>
        {
            entity.HasKey(e => e.IdEstadoReceta).HasName("PK__Estado_R__9A4CA386A2A74B1F");

            entity.ToTable("EstadoReceta");

            entity.Property(e => e.IdEstadoReceta).HasColumnName("IdEstadoReceta");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LugarRetiro>(entity =>
        {
            entity.HasKey(e => e.IdLugarRetiro).HasName("PK__Lugar_Re__2A341DE6B67DBAFF");

            entity.ToTable("LugarRetiro");

            entity.Property(e => e.IdLugarRetiro).HasColumnName("IdLugarRetiro");
            entity.Property(e => e.NombreLugar)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NombreLugar");
        });

        modelBuilder.Entity<LugarAtencion>(entity =>
        {
            entity.HasKey(e => e.IdAtencion).HasName("PK__Lugar_Re__2A341DE6B67DBAFF");

            entity.ToTable("LugarAtencion");

            entity.Property(e => e.IdAtencion).HasColumnName("IdAtencion");
            entity.Property(e => e.NombreLugar)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NombreLugar");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
