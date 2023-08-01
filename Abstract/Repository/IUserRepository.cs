using CommServices.Core.Abstract.EntityCore;
using CommServices.Core.Entity;

namespace CommServices.Core.Abstract.Repository
{
    public interface IUserRepository : IRepository<User, long>
    {
        //List<User> SelectAll();
        void AddNewUser(User user);

        void Test();

        bool AuthorizationAdmit(User user);

        bool AuthorizationUser(User user);

        User Get(string UserName, string password);

        User Get(string username);
    }
}
