using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.Models.Models
{
    public class RefreshToken:CommonModel
    {
        public int uid { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public string CreatedByIp { get; set; }
        public DateTime? Revoked { get; set; }
        public string RevokedByIp { get; set; }
        public string Refreshtoken { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;
    }
}
