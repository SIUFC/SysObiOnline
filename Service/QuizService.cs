using Microsoft.EntityFrameworkCore;
using SysObiOnline.Data;
using SysObiOnline.DTOS;
using SysObiOnline.Models;
using SysObiOnline.Repository;
using SysObiOnline.Repository.Interface;
using System.Security.Claims;

namespace SysObiOnline.Service
{
    public class QuizService
    {
        private readonly IQuestionInterface _questionRepository;
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public QuizService(
            IQuestionInterface questionRepository,
            AppDbContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _questionRepository = questionRepository;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<QuizSummaryDTO> SubmitAnswer(AnswerDTO dto)
        {
            var questionvar = await _questionRepository.GetQuestionById(dto.QuestionId);
            if (questionvar == null)
                throw new ArgumentException("Questão Não Encontrada.");

            bool isCorrect = questionvar.CorrectAnswer.Trim().ToLower().Equals(dto.SubmittedAnswer.Trim(), StringComparison.CurrentCultureIgnoreCase);

            var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var answer = new AnswerGiven
            {
                Level = questionvar.Level,
                IsCorrect = isCorrect
            };

            var result = new QuizResult
            {
                UserId = userId,
                TotalCorrect = isCorrect ? 1 : 0,
                TotalIncorrect = isCorrect ? 0 : 1,
                AnswersGiven = new List<AnswerGiven> { answer }
            };

            await _context.QuizResults.AddAsync(result);
            await _context.SaveChangesAsync();

            var summary = new QuizSummaryDTO
            {
                TotalQuestions = 1,
                TotalCorrect = result.TotalCorrect,
                TotalIncorrect = result.TotalIncorrect,
                Level1Count = questionvar.Level == "1" ? 1 : 0,
                Level2Count = questionvar.Level == "2" ? 1 : 0,
                Level3Count = questionvar.Level == "3" ? 1 : 0,
                Message = isCorrect ? "Resposta Correta!" : "Resposta Incorreta."
            };

            return summary;
        }

        public async Task<QuizSummaryDTO> GetUserReport(int userId)
        {
            var results = await _context.QuizResults
                .Include(r => r.AnswersGiven)
                .Where(r => r.UserId == userId)
                .ToListAsync();

            var allAnswers = results.SelectMany(r => r.AnswersGiven);

            return new QuizSummaryDTO
            {
                TotalQuestions = allAnswers.Count(),
                TotalCorrect = allAnswers.Count(a => a.IsCorrect),
                TotalIncorrect = allAnswers.Count(a => !a.IsCorrect),
                Level1Count = allAnswers.Count(a => a.Level == "1"),
                Level2Count = allAnswers.Count(a => a.Level == "2"),
                Level3Count = allAnswers.Count(a => a.Level == "3"),
                Message = "Relatório gerado com sucesso."
            };
        }
    }

}
