using CommServices.Core.Abstract.Entity;
using CommServices.Core.Abstract.Repository;
using CommServices.Core.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.Repository {
    public abstract class CoreRepository<T, DB> : ICoreRepository<T, long>
        where T : Entity
        where DB : BaseDb, new() {

        protected DB m_db { get; private set; }
        public CoreRepository(DB db) {
            m_db = db;
        }
    }
}
