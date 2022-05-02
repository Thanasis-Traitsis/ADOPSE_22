using ExamGate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace ExamGate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<User>? User { get; set; }

        public DbSet<Option>? Option { get; set; }

        public DbSet<Subject>? Subject { get; set; }

        public DbSet<Exam>? Exam { get; set; }

        public DbSet<Try>? Try { get; set; }

        public DbSet<Question>? Question { get; set; }
    }
}
