using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface IReportService
    {
        Task<FinancialReportDto> GenerateFinancialReportAsync();
        Task<PredictionReportDto> GeneratePredictionReportAsync();
        Task<bool> VerifyPredictionAccuracyAsync(PredictionReportDto predictionReport);
    }
}
