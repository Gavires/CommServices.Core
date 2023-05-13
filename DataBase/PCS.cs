using CommServices.Core.Abstract.Entity;
using System.Data.Entity;

namespace CommServices.Core.DataBase
{
    public class PCS : BaseDb
    {
        //private static string ConectionString { get; } = "DBConnectionProdPCS";
        private static string ConectionString { get; } = "DBConnectionPCS";

        public PCS() : base(ConectionString) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
