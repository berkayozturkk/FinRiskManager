namespace FinRiskManager.Business.DTOs
{
    public class FinancialReportDto
    {
        public string ReportId { get; set; }
        public DateTime GeneratedDate { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetProfit { get; set; }
    }
}
