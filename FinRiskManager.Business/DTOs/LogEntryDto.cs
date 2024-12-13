namespace FinRiskManager.Business.DTOs
{
    public class LogEntryDto
    {
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; } // Info, Warning, Error.
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
