using CommServices.Core.Abstract.Repository;
using CommServices.Core.DataBase;
using CommServices.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommServices.Core.Repository
{
    public class UserRegistrationHistoryRepository : CoreRepository<UserRegistrationHistories, PCS>, IUserRegistrationHistoryRepository
    {
        private readonly IUserRepository userRepository;
        public UserRegistrationHistoryRepository(PCS db, IUserRepository userRepository) : base(db)
        {
            this.userRepository = userRepository;
        }

        public UserRegistrationHistories Get(long id)
        {
            try
            {
                var userRegHistory = new UserRegistrationHistories();
                userRegHistory = m_db.UserRegistrationHistory.FirstOrDefault(x => x.id == id);
                return userRegHistory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserRegistrationHistories> SelectAll(long id)
        {
            try
            {
                var userRegHistoryList = new List<UserRegistrationHistories>();
                userRegHistoryList = m_db.UserRegistrationHistory.Where(x => x.id == id).ToList();
                return userRegHistoryList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Добавляет нового пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void AddHistoryRegistrationUser(User user)
        {
            try
            {
                var newUser = userRepository.Get(user.UserName);
                if (newUser == null)
                {
                    throw new Exception("Пользователь не найде");
                }
                var historyReg = new UserRegistrationHistories()
                {
                    LoginName = newUser.UserName,
                    UserId = newUser.id,
                    RegistrationDate = DateTime.Now,
                    ActionUserId = 1L, //костыль....
                };
                m_db.UserRegistrationHistory.Add(historyReg);
                m_db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
    }
}