using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourShoppee.Models.Contract
{
    public interface ICommonModel
    {
        int Id { get; set; }
        DateTime createdAt { get; set; }
    }
}
