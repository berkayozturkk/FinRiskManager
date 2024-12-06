namespace FinanceRiskManagement.Data.Models
{
    public class Agreement : BaseModel
    {
        public string TenantId { get; set; }
        public string AgreementName { get; set; }
        //public string AgreementDetails { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<RiskAnalysis> RiskAnalyses { get; set; }
        public ICollection<AgreementBusinessTopic> AgreementBusinessTopics { get; set; }
    }
}
