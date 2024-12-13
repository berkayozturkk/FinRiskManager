using FinanceRiskManagement.Data.Models;
using FinRiskManager.Business.DTOs;
using FinRiskManager.Business.Interfaces;
using FinRiskManager.Data.Interfaces;

namespace FinRiskManager.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> CreateUserAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> Authenticate(string username, string password)
        {
            User user = await _userRepository.Authenticate(username, password);

            if (user == null)
                return null;

            UserDto result = new UserDto()
            {
                TenantId = user.TenantId,
                Email = user.Email,
                Role = user.Role,
                Id = user.Id
            };

            return result;
        }
    }
}
