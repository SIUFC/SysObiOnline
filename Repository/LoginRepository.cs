using SysObiOnline.Data;
using SysObiOnline.Models;
using SysObiOnline.Repository.Interface;

namespace SysObiOnline.Repository
{
    public class LoginRepository : ILoginInterface
    {
        private readonly AppDbContext _context;
        public LoginRepository(AppDbContext context) 
        {
            _context = context;
        }
        public async Task CreateLogin(Login login)
        {
            _context.Login.Add(login);
            await _context.SaveChangesAsync();
        }

        public Task GetLogin(string LoginName, string LoginPassword)
        {
            throw new NotImplementedException();
        }
    }
}
