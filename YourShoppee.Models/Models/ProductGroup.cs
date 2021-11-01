using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.Models.Models
{
    public class ProductGroup:CommonModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public virtual IList<Catergory> Catergories { get; set; }
        public virtual IList<ProductType> ProductTypes { get; set; }
        public virtual IList<Product> Products { get; set; }
    }
}
