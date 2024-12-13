using FinanceRiskManagement.Data.Contexts;
using FinanceRiskManagement.Data.Models;
using FinRiskManager.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Data.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly BaseDbContext _context;

        public UserRepository(BaseDbContext context) : base(context)
        {
            _context = context;
        }

        public Task AddAsync(Agreement entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Authenticate(string username, string password)
        {
            // Kullanıcıyı username'e göre bul
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username);

            // Kullanıcı adı bulunamazsa null döner
            if (user == null)
                return null;

            // Şifreyi kontrol et (gerçek uygulamalarda hashing yapılmalı)
            if (user.PasswordHash != password)
                return null;

            // Eğer kullanıcı bulunduysa ve şifre doğrulandıysa, kullanıcıyı döner
            return user;
        }


        public void Delete(Agreement entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Agreement>> FindAsync(Expression<Func<Agreement, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Agreement entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Agreement>> IGenericRepository<Agreement>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Agreement?> IGenericRepository<Agreement>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
