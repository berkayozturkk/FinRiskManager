using FinRiskManager.Business.DTOs;

namespace FinRiskManager.Business.Interfaces
{
    public interface IBusinessTopicService
    {
        Task<IEnumerable<BusinessTopicDto>> GetAllTopicsAsync();
        Task<BusinessTopicDto> GetTopicByIdAsync(string id);
        Task<bool> CreateTopicAsync(BusinessTopicDto topic);
        Task<bool> UpdateTopicAsync(BusinessTopicDto topic);
        Task<bool> DeleteTopicAsync(string id);
    }
}
