using CommServices.Core.Abstract.EntityCore;
using CommServices.Core.Entity;

namespace CommServices.Core.Abstract.Repository
{
    public interface ICoreRepository<T, U>
        where T : BaseEntity<U>
        where U : struct
    {
    }
}
