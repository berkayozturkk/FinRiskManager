namespace FinRiskManager.Business.DTOs
{
    public class RiskResultDto
    {
        public string Id { get; set; }
        public string AgreementId { get; set; }
        public decimal RiskValue { get; set; }
        public DateTime CalculationDate { get; set; }
        public string Details { get; set; } // Risk analizi hakkında detaylı bilgi.
    }
}
