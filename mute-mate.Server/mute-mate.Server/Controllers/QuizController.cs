using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mute_mate.Server.Data.Repo;
using System.Text.Json.Serialization;
using System.Text.Json;
using MuteMate.Server.Models;

namespace mute_mate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly QuizRepo _quizRepo;

        private JsonSerializerOptions _jsonSerializerOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve // Konfigurering av JSON-serialisering
        };


        public QuizController(QuizRepo quizRepo)
        {
            _quizRepo = quizRepo;
        }

        [HttpGet("GetCategoryColors")]
        public async Task<IActionResult> GetCategoryColorsAsync()
        {
            List<QuestionModel> categoryColors = await _quizRepo.GetCategoryColor();
            if (categoryColors == null)
            {
                return NotFound();
            }
            else
            {
                var responsesJson = JsonSerializer.Serialize(categoryColors, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
            }
        }




        [HttpGet("GetCategoryLetters")]

        public async Task<IActionResult> GetCategoryLettersAsync()
        {

            List<QuestionModel> categoryLetters = await _quizRepo.GetCategoryLetters();
            if (categoryLetters == null)
            {
                return NotFound();

            }
            else

            {

                var responsesJson = JsonSerializer.Serialize(categoryLetters, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
                //return Ok(categoryLetters);
            }

        }
        [HttpGet("GetCategoryAnimals")]

        public async Task<IActionResult> GetCategoryAnimalsAsync()
        {

            List<QuestionModel> categoryAnimals = await _quizRepo.GetCategoryAnimals();
            if (categoryAnimals == null)
            {
                return NotFound();

            }
            else
            {

                var responsesJson = JsonSerializer.Serialize(categoryAnimals, _jsonSerializerOptions);
                return Content(responsesJson, "application/json");
                //return Ok(categoryAnimals);
            }

        }
    }
}
