using CommServices.Core.Abstract.EntityCore;
using CommServices.Core.Abstract.Repository;
using CommServices.Core.Abstract.Validations;
using CommServices.Core.DataBase;
using CommServices.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommServices.Core.Repository
{
    public class UserRepository : CoreRepository<User, PCS>, IUserRepository
    {
        public UserRepository(PCS db) : base(db) { }

        //private PCS m_db { get; set; }

        /// <summary>
        /// Возвращает пользователя по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public User Get(long id)
        {
            try
            {
                var user = new User();
                user = m_db.Users.FirstOrDefault(x => x.id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Возвращает пользователя по логину и паролю
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Get(string username, string password)
        {
            try
             {
                var user = m_db.Users.FirstOrDefault(x => x.UserName.Equals(username, StringComparison.CurrentCulture)
                                                          && x.Password.Equals(password, StringComparison.CurrentCulture));
                return user;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public User Get(string username)
        {
            try
            {
                var user = m_db.Users.FirstOrDefault(x => x.UserName.Equals(username, StringComparison.CurrentCulture));
                return user;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Test()
        {
            var user = new User { Name = "Test", Password = "Test1" };
            using (m_db)
            {
                m_db.Users.Add(user);
                m_db.SaveChanges();
            }
        }

        public List<User> SelectAll(long id)
        {
            throw new NotImplementedException();
        }

        public bool AuthorizationAdmit(User user) => user.IsAdmin;

        public bool AuthorizationUser(User user) => Get(user.UserName, user.Password) != null ? true : false;

        public void AddNewUser(User user)
        {
            try
            {
                AddUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Добавляет нового пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private void AddUser(User user)
        {

            m_db.Users.Add(user);
            m_db.SaveChanges();
        }
    }
}
