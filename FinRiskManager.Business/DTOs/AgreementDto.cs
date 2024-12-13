namespace FinRiskManager.Business.DTOs
{
    public class AgreementDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TenantId { get; set; }
    }
}
