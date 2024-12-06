namespace FinanceRiskManagement.Data.Models
{
    public class User : BaseModel
    {
        public string TenantId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public Tenant Tenant { get; set; }
    }
}
