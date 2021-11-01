using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.Contract;
using YourShoppee.Models.Enums;

namespace YourShoppee.Models.Models
{
    public class ApplicationUser : IdentityUser<int>, ICommonModel
    {
        public string Name { get; set; }
        public Gender gender { get; set; }
        public UserType userType { get; set; }
        public DateTime createdAt { get; set; }
    }
}
