using ExamGate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;



namespace ExamGate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

<<<<<<< Updated upstream
        public DbSet<User> User { get; set; }
=======
        public DbSet<User>? User { get; set; }

        public DbSet<Option>? Option { get; set; }

        public DbSet<Subject>? Subject { get; set; }

        public DbSet<Exam>? Exam { get; set; }

        public DbSet<Try>? Try { get; set; }

        public DbSet<Question>? Question { get; set; }

        public DbSet<Exam_Question>? Exam_Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam_Question>()
                .HasKey(eq => new { eq.ExamId, eq.QuestionId });

            modelBuilder.Entity<Exam_Question>()
                .HasOne(e => e.Exam)
                .WithMany(eq => eq.Exam_Questions)
                .HasForeignKey(e => e.ExamId);

            modelBuilder.Entity<Exam_Question>()
                .HasOne(q => q.Question)
                .WithMany(eq => eq.Exam_Questions)
                .HasForeignKey(q => q.QuestionId);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasNoKey();

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasNoKey();
        }
>>>>>>> Stashed changes
    }


}
