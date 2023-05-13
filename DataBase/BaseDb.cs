using System.Data.Entity;

namespace CommServices.Core.DataBase
{
    public class BaseDb : DbContext
    {
        public BaseDb(string conection)
            : base(conection) { }
    }
}
