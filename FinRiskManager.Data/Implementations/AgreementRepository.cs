using FinanceRiskManagement.Data.Contexts;
using FinanceRiskManagement.Data.Models;
using FinRiskManager.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Data.Implementations
{
    public class AgreementRepository : GenericRepository<Agreement>, IAgreementRepository
    {
        private readonly BaseDbContext _context;

        public AgreementRepository(BaseDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Agreement>> GetAgreementsByTenantIdAsync(string tenantId)
        {
            return await _context.Agreements
                .Where(a => a.TenantId == tenantId)
                .ToListAsync();
        }
    }
}
