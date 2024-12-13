using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface IAdminService
    {
        Task<AdminDashboardDto> GetDashboardOverviewAsync();
        Task<bool> ManageUsersAsync(UserDto user);
        Task<bool> ManagePartnersAsync(PartnerDto partner);
    }
}
