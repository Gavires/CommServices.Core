using System;

namespace CommServices.Core.Entity
{
    public class UserRegistrationHistory : EntityCore
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationIp { get; set; }
        public string RegistrationCountry { get; set; }
        public string RegistrationDevice { get; set; }
        public string ReferralCode { get; set; }
        public int ActionId { get; set; }
    }
}
