using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Models.BaseClass;
using YourShoppee.Models.Enums;

namespace YourShoppee.Models.Models
{
    public class Product:CommonModel
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public int CategoryId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductGroupId { get; set; }
        public int Mrp { get; set; }
        public int UnitId { get; set; }
        public int Qty { get; set; }
        public StatusType status { get; set; }
        public virtual Unit unit { get; set; }
    }
}
