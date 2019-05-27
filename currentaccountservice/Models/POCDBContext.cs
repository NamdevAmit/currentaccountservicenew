using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CurrentAccountService.Models
{
    public partial class POCDBContext : DbContext
    {
        public POCDBContext()
        {
        }

        public POCDBContext(DbContextOptions<POCDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=POCDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BloblatAmmendedDate)
                    .HasColumnName("BLOBLatAmmendedDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BrachNo)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnName("createDateTime")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("text");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnName("updateDateTime")
                    .HasColumnType("smalldatetime");
            });
        }
    }
}
