using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.Models.Models
{
    public class Catergory:CommonModel
    {
        public string Name { get; set; }
        public int ProductGroupId { get; set; }
        public ProductGroup productGroup { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
