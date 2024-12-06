using FinanceRiskManagement.Data.Models;

namespace FinRiskManager.Data.Interfaces
{
    public interface IAgreementRepository : IGenericRepository<Agreement>
    {
        Task<IEnumerable<Agreement>> GetAgreementsByTenantIdAsync(string tenantId);
    }
}
