using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApi2.Domain.Entities;
using WebApi2.Domain.Repositories;

namespace WebApi2.Infrastructure
{
    public class DataContext : DbContext, IUnitOfWork
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<UserClassesTaken>()
        //        .HasKey(c => new { c.UserId, c.ClassId });

        //    modelBuilder.Entity<ClassQuiz>()
        //       .HasKey(c => new { c.ClassId, c.QuizId });


        //    modelBuilder.Entity<UserClassesTaken>()
        //.Property(b => b.IsQuizCompleted)
        //.HasDefaultValue(false); // must install package : install-package Microsoft.EntityFrameworkCore.SqlServer


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseLoggerFactory(LoggerFactory);
        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        // public static readonly LoggerFactory LoggerFactory =
        //new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });

    }
}
