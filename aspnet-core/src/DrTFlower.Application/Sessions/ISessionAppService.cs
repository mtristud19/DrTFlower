using System.Threading.Tasks;
using Abp.Application.Services;
using DrTFlower.Sessions.Dto;

namespace DrTFlower.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
