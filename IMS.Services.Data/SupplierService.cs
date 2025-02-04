using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels.Supplier;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data
{
    public class SupplierService : BaseService, ISupplierService
    {
        private readonly IRepository repository;

        public SupplierService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<SupplierServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<Supplier>()
                .Select(s => new SupplierServiceModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();
        }
    }
}
