using SysObiOnline.DTOS;
using SysObiOnline.Models;
using SysObiOnline.Repository.Interface;

namespace SysObiOnline.Service
{
    public class QuestionService
    {
        private readonly IQuestionInterface _questionRepository;
        public QuestionService(IQuestionInterface questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<Question> CreateQuestion(Question question)
        {
            var newquestion = new Question
            {
                Name = question.Name,
                Level = question.Level,
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

        public async Task<Question> UpdateQuestion(Question question, string name, string level, string content, string nameQ)
        {
            var getquestion = await _questionRepository.GetQuestionByName(name);
            if (getquestion == null) throw new ArgumentNullException("Você digitou uma questão nula!");
            
            getquestion.Name = nameQ;
            getquestion.Level = level;
            getquestion.Content = content;

            await _questionRepository.UpdateQuestion(question);
            return getquestion;
            
        }

    }
}
