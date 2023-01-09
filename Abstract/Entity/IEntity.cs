using System;
using System.Collections.Generic;
using System.Text;

namespace CommServices.Core.Abstract.Entity {
    public interface IEntity <T> where T: struct {
        T ID { get; set; }  
    }
}
