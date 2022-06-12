using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infraestructure.Persistence.Contents
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Concept> Concept { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
