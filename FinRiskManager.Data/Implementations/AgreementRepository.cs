using FinanceRiskManagement.Data.Contexts;
using FinanceRiskManagement.Data.Models;
using FinRiskManager.Data.Interfaces;
using FinRiskManager.Business.DTOs;
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

        public async Task<IEnumerable<AgreementRiskDto>> GetAgreementsWithRiskByTenantIdAsync(string tenantId)
        {
            //return await _context.Agreements
            //    .Where(a => a.TenantId == tenantId)
            //    .ToListAsync();

            return await (from agreement in _context.Agreements
                          join abt in _context.AgreementBusinessTopics on agreement.Id equals abt.AgreementId
                          join topic in _context.BusinessTopics on abt.BusinessTopicId equals topic.Id
                          join risk in _context.RiskAnalyses on topic.Id equals risk.Id into riskGroup
                          from rg in riskGroup.DefaultIfEmpty()
                          where agreement.TenantId == tenantId
                          select new AgreementRiskDto
                          {
                              AgreementName = agreement.AgreementName,
                              AgreementDate = agreement.AgreementDate,
                              TopicName = topic.Name,
                              RiskAmount = rg != null ? rg.RiskAmount : 0
                          }).ToListAsync();
        }
    }
}
