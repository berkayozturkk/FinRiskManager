namespace FinanceRiskManagement.Data.Models
{
    public class AgreementBusinessTopic : BaseModel
    {
        public string AgreementId { get; set; }
        public string BusinessTopicId { get; set; }

        public Agreement Agreement { get; set; }
        public BusinessTopic BusinessTopic { get; set; }
    }
}
