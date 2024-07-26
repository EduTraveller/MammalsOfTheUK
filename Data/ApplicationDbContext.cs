using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MammalsOfTheUK.Entities;

namespace MammalsOfTheUK.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Mammal> Mammals { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
        public DbSet<RiskCategory> RiskCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure composite primary key for UserQuiz
            builder.Entity<UserQuiz>()
                .HasKey(uq => new { uq.UserID, uq.QuizID });

            builder.Entity<RiskCategory>()
                .HasKey(uq => new { uq.MammalID});
                  

            // Additional configurations if needed
        }
    }
}
