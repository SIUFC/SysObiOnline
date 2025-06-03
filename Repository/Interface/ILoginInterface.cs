using SysObiOnline.Models;

namespace SysObiOnline.Repository.Interface
{
    public interface ILoginInterface
    {
        public Task CreateLogin(string LoginName, string LoginPassword);
        public Task GetLogin(string LoginName, string LoginPassword);
    }
}
