using FinRiskManager.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinRiskManager.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IAgreementService _agreementService;

        public DashboardController(IAgreementService agreementService)
        {
            _agreementService = agreementService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Anlaşmaları JSON formatında döner
        [HttpGet("GetAgreementsWith")]
        public async Task<IActionResult> GetAgreementsWith()
        {
            string tenantId = "test";
            var agreements = await _agreementService.GetAgreementsWithRiskByTenantIdAsync(tenantId);
            return Ok(agreements);
        }
    }
}
