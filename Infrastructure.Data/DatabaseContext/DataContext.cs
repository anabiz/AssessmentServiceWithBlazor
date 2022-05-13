using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Name = "Lexus 122",
                     Price = 100.35M
                 },
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Name = "Toyota 330",
                     Price = 90.35M
                 },
                 new Product
                 {
                     Id = Guid.NewGuid(),
                     Name = "Mesdix 992",
                     Price = 105.35M
                 },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Lexus 992",
                    Price = 105.35M
                }
            );

            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuestionOptionConfiguration).Assembly);
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }

    }
}
