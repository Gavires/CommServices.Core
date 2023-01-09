using System;
using System.Collections.Generic;
using System.Text;

namespace CommServices.Core.Abstract.Entity {
    public class Admin : Entity {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get { return true; } }
    }
}
