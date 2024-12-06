namespace FinanceRiskManagement.Data.Models
{
    public class RiskAnalysis : BaseModel
    {
        public string AgreementId { get; set; }
        public decimal RiskAmount { get; set; }

        public Agreement Agreement { get; set; }
    }
}
