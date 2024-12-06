namespace FinanceRiskManagement.Data.Models
{
    public class Tenant : BaseModel
    {
        public string TenantName { get; set; }
        public string TenantDescription { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
