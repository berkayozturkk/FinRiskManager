using FinanceRiskManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Data.Interfaces
{
    public interface IUserRepository : IGenericRepository<Agreement>
    {
        Task<User> Authenticate(string username, string password);
    }
}
