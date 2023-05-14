using CommServices.Core.Abstract.Repository;
using CommServices.Core.DataBase;
using CommServices.Core.Entity;

namespace CommServices.Core.Repository
{
    public abstract class CoreRepository<T, DB> : ICoreRepository<T, long>
        where T : EntityCore
        where DB : BaseDb, new()
    {

        protected DB m_db { get; private set; }
        public CoreRepository(DB db)
        {
            m_db = db;
        }
    }
}
