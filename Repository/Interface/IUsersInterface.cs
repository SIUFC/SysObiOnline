using SysObiOnline.Models;

namespace SysObiOnline.Repository.Interface
{
    public interface IUsersInterface
    {
        public Task CreateUser(Users users);
        public Task UpdateUser(Users users);
        public Task DeleteUser(Users users);
        public Task<Users> GetUsers();
    }
}
