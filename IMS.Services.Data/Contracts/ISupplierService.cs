using IMS.Data.Repository.Contracts;
using IMS.Web.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data.Contracts
{
    public interface ISupplierService
    {
        Task<IEnumerable<SupplierServiceModel>> AllAsync();
    }
}
