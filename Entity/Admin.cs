namespace CommServices.Core.Entity
{
    public class Admin : EntityCore
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get { return true; } }
    }
}
