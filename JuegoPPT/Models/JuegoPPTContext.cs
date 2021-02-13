using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace JuegoPPT.Models
{
    public partial class JuegoPPTContext : DbContext
    {
        public JuegoPPTContext()
        {
        }

        public JuegoPPTContext(DbContextOptions<JuegoPPTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Juego> Juegos { get; set; }
        public virtual DbSet<Jugador1> Jugador1s { get; set; }
        public virtual DbSet<Jugador2> Jugador2s { get; set; }
        public virtual DbSet<Ronda> Ronda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=AFC-PC\\SQLEXPRESS;Database=JuegoPPT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Juego>(entity =>
            {
                entity.HasKey(e => e.CodigoJuego)
                    .HasName("PK__Juego__D9BE5F62390E2991");

                entity.ToTable("Juego");

                entity.Property(e => e.CodigoJuego)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_juego");

                entity.Property(e => e.CodigoJugador1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_1");

                entity.Property(e => e.CodigoJugador2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_2");

                entity.HasOne(d => d.CodigoJugador1Navigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.CodigoJugador1)
                    .HasConstraintName("FK__Juego__codigo_ju__3A81B327");

                entity.HasOne(d => d.CodigoJugador2Navigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.CodigoJugador2)
                    .HasConstraintName("FK__Juego__codigo_ju__3B75D760");
            });

            modelBuilder.Entity<Jugador1>(entity =>
            {
                entity.HasKey(e => e.CodigoJugador1)
                    .HasName("PK__Jugador1__463A45A731E326BE");

                entity.ToTable("Jugador1");

                entity.Property(e => e.CodigoJugador1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_1");

                entity.Property(e => e.NombreJugador1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre_jugador1");
            });

            modelBuilder.Entity<Jugador2>(entity =>
            {
                entity.HasKey(e => e.CodigoJugador2)
                    .HasName("PK__Jugador2__463A45A6CA42AB95");

                entity.ToTable("Jugador2");

                entity.Property(e => e.CodigoJugador2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_2");

                entity.Property(e => e.NombreJugador2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre_jugador2");
            });

            modelBuilder.Entity<Ronda>(entity =>
            {
                entity.HasKey(e => e.CodigoRonda)
                    .HasName("PK__Ronda__1202A179BE0FAD5C");

                entity.Property(e => e.CodigoRonda)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_ronda");

                entity.Property(e => e.CodigoJuego)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_juego");

                entity.Property(e => e.CodigoJugador1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_1");

                entity.Property(e => e.CodigoJugador2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("codigo_jugador_2");

                entity.Property(e => e.MovimientoJugador1).HasColumnName("movimiento_jugador_1");

                entity.Property(e => e.MovimientoJugador2).HasColumnName("movimiento_jugador_2");

                entity.Property(e => e.NumeroRonda).HasColumnName("numero_ronda");

                entity.HasOne(d => d.CodigoJuegoNavigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.CodigoJuego)
                    .HasConstraintName("FK__Ronda__codigo_ju__3E52440B");

                entity.HasOne(d => d.CodigoJugador1Navigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.CodigoJugador1)
                    .HasConstraintName("FK__Ronda__codigo_ju__3F466844");

                entity.HasOne(d => d.CodigoJugador2Navigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.CodigoJugador2)
                    .HasConstraintName("FK__Ronda__codigo_ju__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
