using CommServices.Core.Abstract.Entity;

namespace CommServices.Core.Abstract.Repository
{
    public interface IUserRepository : IRepository<User, long>
    {
        //List<User> SelectAll();
        void RegisteringNewUser(User user);

        void Test();

        bool AuthorizationAdmit(User user);

        bool AuthorizationUser(User user);
    }
}
