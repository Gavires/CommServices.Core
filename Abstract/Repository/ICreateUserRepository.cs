using CommServices.Core.Entity;

namespace CommServices.Core.Abstract.Repository
{
    public interface ICreateUserRepository
    {
        bool RegisteringNewUser(User user);
    }
}
