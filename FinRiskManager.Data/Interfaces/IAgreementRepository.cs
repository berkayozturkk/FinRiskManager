using FinanceRiskManagement.Data.Models;
using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Data.Interfaces
{
    public interface IAgreementRepository : IGenericRepository<Agreement>
    {
        Task<IEnumerable<AgreementRiskDto>> GetAgreementsWithRiskByTenantIdAsync(string tenantId);
    }
}
