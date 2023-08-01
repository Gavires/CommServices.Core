using System;

namespace CommServices.Core.Entity
{
    public class UserRegistrationHistories : EntityCore
    {
        public long UserId { get; set; }
        public string LoginName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationIp { get; set; }
        public string RegistrationCountry { get; set; }
        public string RegistrationDevice { get; set; }
        public string ReferralCode { get; set; }
        public long ActionUserId { get; set; }
    }
}
