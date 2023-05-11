using CommServices.Core.Abstract.Entity;
using System.Data.Entity;

namespace CommServices.Core.DataBase
{
    public class PCS : BaseDb
    {

        public PCS() : base("DBConnectionPCS")
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
