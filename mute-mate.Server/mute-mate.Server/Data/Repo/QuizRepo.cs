using Microsoft.EntityFrameworkCore;
using MuteMate.Server.Data;
using MuteMate.Server.Models;

namespace mute_mate.Server.Data.Repo
{
    public class QuizRepo
    {
        private readonly MuteMateDbContext context;

        public QuizRepo(MuteMateDbContext context)
        {
            this.context = context; 
        }


        public async Task<List<QuestionModel>> GetCategoryColor()
        {
           return await context.Questions.Where(q => q.Category == "Colors").Include( q=> q.Answers).ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryLetters()
        {
            return await context.Questions.Where(q => q.Category == "Letters").Include(q=> q.Answers).ToListAsync();

        }

        public async Task<List<QuestionModel>> GetCategoryAnimals()
        {
            return await context.Questions.Where(q => q.Category == "Animals").Include(q => q.Answers).ToListAsync();

        }


    }
}
