using System;
using System.Collections.Generic;
using System.Text;

namespace CommServices.Core.Abstract.Entity {
    public class BaseEntity<T> : IEntity<T> where T : struct {
        public T ID { get; set; }
    }
}
