using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.Models.Models
{
    public class Unit:CommonModel
    {
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
