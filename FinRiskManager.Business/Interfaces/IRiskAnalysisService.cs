using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface IRiskAnalysisService
    {
        Task<RiskResultDto> CalculateRiskAsync(string agreementId);
        Task<bool> SaveRiskResultAsync(RiskResultDto riskResult);
        Task<IEnumerable<RiskResultDto>> GetRiskResultsAsync(string agreementId);
    }
}
