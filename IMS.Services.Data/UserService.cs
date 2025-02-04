using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<UserServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<ApplicationUser>()
                .Include(u => u.Employee)
                .Select(u => new UserServiceModel()
                {
                    Email = u.Email,
                    FullName = u.FirstName + " " + u.LastName,
                    IsEmployee = u.Employee != null
                }).ToListAsync();
        }

        public async Task<int> UsersCountAsync()
        {
            return await repository.AllReadOnly<ApplicationUser>()
                .CountAsync();
        }
    }
}
