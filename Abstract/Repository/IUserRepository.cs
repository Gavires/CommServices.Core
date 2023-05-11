using CommServices.Core.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.Abstract.Repository {
    public interface IUserRepository : IRepository<User, long> {
        //List<User> SelectAll();
        void AddUser(User user);
        
        void Test();

        bool AutorizationAdmit(User user);

        bool AutorizationUser(User user);
    }
}
