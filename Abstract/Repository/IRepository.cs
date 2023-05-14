using CommServices.Core.Entity;
using System.Collections.Generic;

namespace CommServices.Core.Abstract.Repository
{
    public interface IRepository<T, U>
        where T : BaseEntity<U>
        where U : struct
    {

        T Get(long id);
        List<T> SelectAll(long id);
    }
}
