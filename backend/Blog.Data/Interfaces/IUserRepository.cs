using Blog.Model.Entities;

namespace Blog.Data.Interfaces
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool IsUsernameUniq(string username);
        bool isEmailUniq(string email);
    }
}