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
                entity.HasKey(e => e.RowidJuego)
                    .HasName("PK__Juego__FCBF20EB7774A2EF");

                entity.ToTable("Juego");

                entity.Property(e => e.RowidJuego).HasColumnName("rowid_juego");

                entity.Property(e => e.RowidJugador1).HasColumnName("rowid_jugador_1");

                entity.Property(e => e.RowidJugador2).HasColumnName("rowid_jugador_2");

                entity.HasOne(d => d.RowidJugador1Navigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.RowidJugador1)
                    .HasConstraintName("FK__Juego__rowid_jug__2A4B4B5E");

                entity.HasOne(d => d.RowidJugador2Navigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.RowidJugador2)
                    .HasConstraintName("FK__Juego__rowid_jug__2B3F6F97");
            });

            modelBuilder.Entity<Jugador1>(entity =>
            {
                entity.HasKey(e => e.RowidJugador1)
                    .HasName("PK__Jugador1__6CA177392071C00F");

                entity.ToTable("Jugador1");

                entity.Property(e => e.RowidJugador1).HasColumnName("rowid_jugador_1");

                entity.Property(e => e.NombreJugador1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre_jugador1");
            });

            modelBuilder.Entity<Jugador2>(entity =>
            {
                entity.HasKey(e => e.RowidJugador2)
                    .HasName("PK__Jugador2__6CA1773884A61D15");

                entity.ToTable("Jugador2");

                entity.Property(e => e.RowidJugador2).HasColumnName("rowid_jugador_2");

                entity.Property(e => e.NombreJugador2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nombre_jugador2");
            });

            modelBuilder.Entity<Ronda>(entity =>
            {
                entity.HasKey(e => e.RowidRonda)
                    .HasName("PK__Ronda__0B2D53366C948F4B");

                entity.Property(e => e.RowidRonda).HasColumnName("rowid_ronda");

                entity.Property(e => e.MovimientoJugador1).HasColumnName("movimiento_jugador_1");

                entity.Property(e => e.MovimientoJugador2).HasColumnName("movimiento_jugador_2");

                entity.Property(e => e.NumeroRonda).HasColumnName("numero_ronda");

                entity.Property(e => e.RowidJuego).HasColumnName("rowid_juego");

                entity.Property(e => e.RowidJugador1).HasColumnName("rowid_jugador_1");

                entity.Property(e => e.RowidJugador2).HasColumnName("rowid_jugador_2");

                entity.HasOne(d => d.RowidJuegoNavigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.RowidJuego)
                    .HasConstraintName("FK__Ronda__rowid_jue__300424B4");

                entity.HasOne(d => d.RowidJugador1Navigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.RowidJugador1)
                    .HasConstraintName("FK__Ronda__rowid_jug__2E1BDC42");

                entity.HasOne(d => d.RowidJugador2Navigation)
                    .WithMany(p => p.Ronda)
                    .HasForeignKey(d => d.RowidJugador2)
                    .HasConstraintName("FK__Ronda__rowid_jug__2F10007B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
