using System.Threading.Tasks;
using Abp.Application.Services;
using DrTFlower.Authorization.Accounts.Dto;

namespace DrTFlower.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
