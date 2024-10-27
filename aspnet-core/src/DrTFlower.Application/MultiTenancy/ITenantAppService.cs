using Abp.Application.Services;
using DrTFlower.MultiTenancy.Dto;

namespace DrTFlower.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

