using SysObiOnline.Models;

namespace SysObiOnline.Repository.Interface
{
    public interface IQuizResultInterface
    {
        public Task SaveResultAsync(QuizResult result);
        public Task<List<QuizResult>> GetResultsByUserAsync(int userId);
    }
}
