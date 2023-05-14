using CommServices.Core.Abstract.Repository;
using CommServices.Core.DataBase;
using CommServices.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CommServices.Core.Repository
{
    public class UserRegistrationHistoryRepository : CoreRepository<UserRegistrationHistory, PCS>, IUserRegistrationHistoryRepository
    {
        public UserRegistrationHistoryRepository(PCS db) : base(db)
        {
        }

        public UserRegistrationHistory Get(long id)
        {
            try
            {
                var userRegHistory = new UserRegistrationHistory();
                userRegHistory = m_db.UserRegistrationHistories.FirstOrDefault(x => x.id == id);
                return userRegHistory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserRegistrationHistory> SelectAll(long id)
        {
            try
            {
                var userRegHistoryList = new List<UserRegistrationHistory>();
                userRegHistoryList = m_db.UserRegistrationHistories.Where(x => x.id == id).ToList();
                return userRegHistoryList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
