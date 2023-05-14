namespace CommServices.Core.Entity {
    public class User : EntityCore {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
