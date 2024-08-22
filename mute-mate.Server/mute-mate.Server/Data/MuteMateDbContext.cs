using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Models;

namespace MuteMate.Server.Data
{
    public class MuteMateDbContext : IdentityDbContext<ApplicationUser>
    {
        public MuteMateDbContext(DbContextOptions<MuteMateDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }

    }
}
