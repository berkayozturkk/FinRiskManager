namespace FinRiskManager.Business.DTOs
{
    public class PredictionReportDto
    {
        public string ReportId { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Description { get; set; }
        public bool IsPredictionAccurate { get; set; }
    }
}
