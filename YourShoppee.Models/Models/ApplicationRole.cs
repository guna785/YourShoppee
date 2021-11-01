using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.Contract;

namespace YourShoppee.Models.Models
{
    public class ApplicationRole : IdentityRole<int>, ICommonModel
    {
        public DateTime createdAt { get; set; }
    }
}
