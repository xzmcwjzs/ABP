using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ntu.xzmcwjzs.MultiTenancy.Dto;

namespace ntu.xzmcwjzs.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
