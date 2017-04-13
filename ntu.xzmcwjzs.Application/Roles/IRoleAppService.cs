using System.Threading.Tasks;
using Abp.Application.Services;
using ntu.xzmcwjzs.Roles.Dto;

namespace ntu.xzmcwjzs.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
