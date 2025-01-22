using IMS.Data.Models;
using IMS.Data.Repository.Contracts;
using IMS.Services.Data.Contracts;
using IMS.Web.ViewModels.Employee;
using Microsoft.EntityFrameworkCore;

namespace IMS.Services.Data
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IRepository repository;

        public EmployeeService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateAsync(BecomeEmployeeFormModel model, string userId)
        {
            var employee = new Employee()
            {
                UserId = userId,
                YearsOfExperience = model.YearsOfExperience,
            };

            await repository.AddAsync(employee);

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(int employeeId)
        {
            return await repository.AllReadOnly<Employee>().AnyAsync(e => e.Id == employeeId);
        }

        public async Task<bool> ExistsByUserIdAsync(string userId)
        {
            return await repository.AllReadOnly<Employee>().AnyAsync(e => e.UserId == userId);
        }

        public async Task<Employee> GetByIdAsync(int employeeId)
        {
            return await repository.All<Employee>()
                .FirstOrDefaultAsync(e => e.Id == employeeId);
        }

        public async Task<int?> GetEmployeeIdByUserId(string userId)
        {
            return (await repository.All<Employee>()
               .FirstOrDefaultAsync(e => e.UserId == userId)).Id;
        }

        public async Task<int> GetYOEByIdAsync(string userId)
        {
            Employee empl = await repository.AllReadOnly<Employee>()
                .FirstOrDefaultAsync(e => e.UserId == userId);

            if (empl == null)
            {
                return -1;
            }

            return empl.YearsOfExperience;
        }
    }
}
