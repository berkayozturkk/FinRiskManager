using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface IAgreementService
    {
        Task<IEnumerable<AgreementDto>> GetAllAgreementsAsync();
        Task<IEnumerable<AgreementRiskDto>> GetAgreementsWithRiskByTenantIdAsync(string tenantId);
        Task<AgreementDto> GetAgreementByIdAsync(string id);
        Task<bool> CreateAgreementAsync(AgreementDto agreement);
        Task<bool> UpdateAgreementAsync(AgreementDto agreement);
        Task<bool> DeleteAgreementAsync(string id);
        Task<bool> AddKeywordToAgreement(string agreementId, string keyword);
    }
}
