using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.Models.Models
{
    public class ProductType:CommonModel
    {
        public string Name { get; set; }
        public int ProductGroupId { get; set; }
        public int CategoryId { get; set; }
        public virtual Catergory category { get; set; }
        public virtual ProductGroup productGroup { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
