using FinRiskManager.Business.DTOs;
using FinRiskManager.Business.Interfaces;
using FinRiskManager.Data.Interfaces;


namespace FinRiskManager.Business.Services;

public class AgreementService : IAgreementService
{
    private readonly IAgreementRepository _agreementRepository;

    public AgreementService(IAgreementRepository agreementRepository)
    {
        _agreementRepository = agreementRepository;
    }

    public Task<bool> AddKeywordToAgreement(string agreementId, string keyword)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CreateAgreementAsync(AgreementDto agreement)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAgreementAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<AgreementDto> GetAgreementByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<AgreementRiskDto>> GetAgreementsWithRiskByTenantIdAsync(string tenantId)
    {
        var agreements
            = await _agreementRepository.GetAgreementsWithRiskByTenantIdAsync(tenantId);

        return agreements;
    }

    public Task<IEnumerable<AgreementDto>> GetAllAgreementsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAgreementAsync(AgreementDto agreement)
    {
        throw new NotImplementedException();
    }
}
