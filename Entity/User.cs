namespace CommServices.Core.Abstract.Entity {
    public class User : Entity {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
