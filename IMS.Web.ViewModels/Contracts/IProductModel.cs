using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Web.ViewModels.Contracts
{
    public interface IProductModel
    {
        string Name { get; set; }

        double Price { get; set; }
    }
}
