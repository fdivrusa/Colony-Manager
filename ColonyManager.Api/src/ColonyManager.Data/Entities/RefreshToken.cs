using System;
using System.Text.Json.Serialization;

namespace ColonyManager.Data.Entities
{
    public class RefreshToken
    {
        [JsonIgnore]
        public long Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsExpired => DateTime.UtcNow >= ExpirationDate;
        public DateTime CreatedDate { get; set; }
        public string CreatedByIpv4 { get; set; }
        public string CreatedByIpv6 { get; set; }
        public DateTime? Revoked { get; set; }
        public string RevokedByIpv4 { get; set; }
        public string RevokedByIpv6 { get; set; }
        public string ReplacedByToken { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;

        public virtual Account Account { get; set; }
    }
}
