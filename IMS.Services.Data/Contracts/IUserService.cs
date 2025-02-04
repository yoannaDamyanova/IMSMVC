

using IMS.Web.ViewModels.User;

namespace IMS.Services.Data.Contracts
{
    public interface IUserService
    {
        Task<int> UsersCountAsync();

        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
