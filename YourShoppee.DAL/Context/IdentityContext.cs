using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.Models;
using Microsoft.EntityFrameworkCore;
namespace YourShoppee.DAL.Context
{
    public class IdentityContext:IdentityDbContext<ApplicationUser,ApplicationRole,int>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
    }
}
