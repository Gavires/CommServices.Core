using CommServices.Core.Abstract.Entity;
using System.Collections.Generic;

namespace CommServices.Core.Abstract.Repository {
    public interface ICoreRepository<T, U>
        where T : BaseEntity<U>
        where U : struct {

        
    }
}
