namespace FinRiskManager.Business.DTOs
{
    public class AdminDashboardDto
    {
        public int TotalUsers { get; set; }
        public int ActiveAgreements { get; set; }
        public int RiskAnalysesCompleted { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenses { get; set; }
    }
}
