using CommServices.Core.Abstract.EntityCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommServices.Core.Entity {
    public class BaseEntity<T> : IEntity<T> where T : struct {
        public T id { get; set; }
    }
}
