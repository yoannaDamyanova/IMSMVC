using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Services.Data.Contracts
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> UsersCountAsync()
        {
            return await repository.AllReadOnly<ApplicationUser>()
                .CountAsync();
        }
    }
}
