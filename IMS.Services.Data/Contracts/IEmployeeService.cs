using IMS.Data.Models;
using System;
using System.Collections.Generic;
using IMS.Web.ViewModels.Employee;

namespace IMS.Services.Data.Contracts
{
    public interface IEmployeeService
    {
        Task<bool> ExistsByIdAsync(int userId);
        Task<bool> ExistsByUserIdAsync(string userId);

        Task CreateAsync(BecomeEmployeeFormModel model, string userId);

        Task<int> GetYOEByIdAsync(string userId);

        public Task<Employee> GetByIdAsync(int userId);

        Task<int> GetEmployeeIdByUserIdAsync(string userId);

        Task<EmployeeOfficeViewModel> GetEmployeeOfficeByUserIdAsync(string employeeId);

        Task<bool> IsApprovedByIdAsync(string userId);

        Task<IEnumerable<EmployeeOfficeViewModel>> AllAsync();
    }
}
