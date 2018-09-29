using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyUserDataModels.Models
{
    public partial class MyBusinessDemoDBContext : DbContext
    {
        public MyBusinessDemoDBContext()
        {
        }

        public MyBusinessDemoDBContext(DbContextOptions<MyBusinessDemoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RoleUserMapping> RoleUserMapping { get; set; }
        public virtual DbSet<SessionUser> SessionUser { get; set; }
        public virtual DbSet<SystemModule> SystemModule { get; set; }
        public virtual DbSet<SystemRole> SystemRole { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLogs> UserLogs { get; set; }
        public virtual DbSet<WebApiMethod> WebApiMethod { get; set; }
        public virtual DbSet<WebApiUserMapping> WebApiUserMapping { get; set; }

        // Unable to generate entity type for table 'dbo.Code'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer("Server=10.211.55.3\\MSSQLSERVER2016;Database=MyBusinessDemoDB;User Id=sa;Password=GELISpass01;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleUserMapping>(entity =>
            {
                entity.HasKey(e => new { e.RoleKey, e.UserId });

                entity.Property(e => e.RoleKey).HasMaxLength(30);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SessionUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SessionID")
                    .HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SystemModule>(entity =>
            {
                entity.HasKey(e => new { e.RoleKey, e.ModuleName });

                entity.Property(e => e.RoleKey).HasMaxLength(30);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(200);
            });

            modelBuilder.Entity<SystemRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(200);

                entity.Property(e => e.RoleKey)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RoleSysName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChtName).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsAdmin)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserLogs>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodeType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperatorDateTime).HasColumnType("datetime");

                entity.Property(e => e.OperatorDesc)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OperatorFunc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebApiMethod>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Desc).HasMaxLength(300);

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RoleKey)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<WebApiUserMapping>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.MethodName, e.RoleKey, e.ModuleName });

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.RoleKey).HasMaxLength(30);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
