using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CA_ImdbDb.Models
{
    public partial class ImdbDataContext : DbContext
    {
        public ImdbDataContext()
        {
        }

        public ImdbDataContext(DbContextOptions<ImdbDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieGenre> MovieGenres { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Trailer> Trailers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5TJ97HC\\SQLEXPRESS;Database=ImdbData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Cast>(entity =>
            {
                entity.HasIndex(e => e.MovieId, "IX_Movie_Id");

                entity.Property(e => e.MovieId).HasColumnName("Movie_Id");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Casts)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_dbo.Casts_dbo.Movies_Movie_Id");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Movies");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Users");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasIndex(e => e.DirectorId, "IX_Director_Id");

                entity.Property(e => e.DirectorId).HasColumnName("Director_Id");

                entity.Property(e => e.RevenueMillions).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.DirectorId)
                    .HasConstraintName("FK_dbo.Movies_dbo.Directors_Director_Id");
            });

            modelBuilder.Entity<MovieGenre>(entity =>
            {
                entity.HasKey(e => new { e.MovieId, e.GenreId })
                    .HasName("PK_dbo.MovieGenres");

                entity.HasIndex(e => e.GenreId, "IX_Genre_Id");

                entity.HasIndex(e => e.MovieId, "IX_Movie_Id");

                entity.Property(e => e.MovieId).HasColumnName("Movie_Id");

                entity.Property(e => e.GenreId).HasColumnName("Genre_Id");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MovieGenres)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK_dbo.MovieGenres_dbo.Genres_Genre_Id");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieGenres)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK_dbo.MovieGenres_dbo.Movies_Movie_Id");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Url).IsRequired();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Picture)
                    .HasForeignKey<Picture>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pictures_Movies");
            });

            modelBuilder.Entity<Trailer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Url).IsRequired();

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Trailers)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trailers_Movies");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
