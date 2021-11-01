using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.Contract;

namespace YourShoppee.Models.BaseClass
{
    public abstract class CommonModel : ICommonModel
    {
        public int Id { get; set; }
        public DateTime createdAt { get; set; }
    }
}
