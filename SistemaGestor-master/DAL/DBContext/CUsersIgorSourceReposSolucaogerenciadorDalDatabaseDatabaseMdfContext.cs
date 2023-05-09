using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MODEL;

namespace DAL.DBContext;

public partial class CUsersIgorSourceReposSistemaGestorDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersIgorSourceReposSistemaGestorDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersIgorSourceReposSistemaGestorDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersIgorSourceReposSistemaGestorDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename =C:\\Users\\igor\\source\\repos\\SistemaGestor\\DAL\\database\\Database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projetos__3214EC075D6934D4");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataDeInicio).HasColumnType("date");
            entity.Property(e => e.DataFinal).HasColumnType("date");
            entity.Property(e => e.Gerente)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Resumo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
