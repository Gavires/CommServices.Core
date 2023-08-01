using CommServices.Core.DataBase;
using CommServices.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.Abstract.Repository
{
    public interface IUserRegistrationHistoryRepository : IRepository<UserRegistrationHistories, long>
    {
        void AddHistoryRegistrationUser(User user);
    }
}
