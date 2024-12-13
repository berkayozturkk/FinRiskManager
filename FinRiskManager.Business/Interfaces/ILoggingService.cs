using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface ILoggingService
    {
        void LogInfo(string message);
        void LogError(string message, Exception ex);
        IEnumerable<LogEntryDto> GetLogs();
    }
}
