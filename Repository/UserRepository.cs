using CommServices.Core.Abstract.Entity;
using CommServices.Core.Abstract.Repository;
using CommServices.Core.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

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
            try {
                var user = new User();
                user = m_db.Users.FirstOrDefault(x => x.ID == id);
                return user;
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public User Get(string username, string password)
        {
            try
            {
                var user = m_db.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
                return user;
            }
            catch (Exception ex) { throw new Exception(ex.Message);}
        }

        

        public void AddUser(User user)
        {
            m_db.Users.Add(user);
            m_db.SaveChanges();
        }

        //public void AddUser(User user) {
        //    using (var db = new PCS()) {
        //        db.Users.Add(user);
        //        db.SaveChanges();
        //    }
        //}

        public void Test()
        {
            var user = new User { Name = "Test", Password = "Test1" };
            using (m_db) {
                m_db.Users.Add(user);
                m_db.SaveChanges();
            }
        }        

        public List<User> SelectAll(long id)
        {
            throw new NotImplementedException();
        }

        public bool AutorizationAdmit(User user) => user.IsAdmin;

        public bool AutorizationUser(User user) => Get(user.UserName, user.Password) != null ? true : false;
    }
}
