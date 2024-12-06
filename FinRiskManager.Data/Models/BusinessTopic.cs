namespace FinanceRiskManagement.Data.Models
{
    public class BusinessTopic : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AgreementBusinessTopic> AgreementBusinessTopics { get; set; }
    }
}
