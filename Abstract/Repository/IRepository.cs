using CommServices.Core.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.Abstract.Repository {
    public interface IRepository<T, U> 
        where T : BaseEntity<U>
        where U : struct{

        T Get(long id);
        List<T> SelectAll(long id);
    }
}
