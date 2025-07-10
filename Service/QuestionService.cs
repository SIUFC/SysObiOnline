using SysObiOnline.Data;
using SysObiOnline.DTOS;
using SysObiOnline.Models;
using SysObiOnline.Repository.Interface;

namespace SysObiOnline.Service
{
    public class QuestionService
    {
        private readonly AppDbContext _context;

        private readonly IQuestionInterface _questionRepository;
        public QuestionService(IQuestionInterface questionRepository, AppDbContext context)
        {
            _questionRepository = questionRepository;
            _context = context;
        }

        public async Task<Question> CreateQuestion(Question question)
        {
            var newquestion = new Question
            {
                Name = question.Name,
                Level = question.Level,
                Content = question.Content,
                Year = question.Year,
                CorrectAnswer = question.CorrectAnswer,
            };

            await _questionRepository.CreateQuestion(newquestion);

            return newquestion;
        }
        public async Task<Question> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("nome nulo ou vazio");
            var getname =  await _questionRepository.GetQuestionByName(name);
            return getname;
        }

        public async Task<Question> UpdateQuestion(string name, Question newData)
        {
            var existingQuestion = await _questionRepository.GetQuestionByName(name);
            if (existingQuestion == null)
                throw new ArgumentNullException("Questão não encontrada!");

            existingQuestion.Name = newData.Name;
            existingQuestion.Level = newData.Level;
            existingQuestion.Content = newData.Content;

            await _questionRepository.UpdateQuestion(existingQuestion);
            return existingQuestion;
        }


    }
}
