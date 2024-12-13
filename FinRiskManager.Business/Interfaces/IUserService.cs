using FinRiskManager.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Business.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(string id);
        Task<bool> CreateUserAsync(UserDto user);
        Task<bool> UpdateUserAsync(UserDto user);
        Task<bool> DeleteUserAsync(string id);
    }
}
