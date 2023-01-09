using CommServices.Core.Abstract.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommServices.Core.DataBase {
    public class BaseDb : DbContext 
        {
        public BaseDb(string conection )
            : base(conection) { }
    }
}
