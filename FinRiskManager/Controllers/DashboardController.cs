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
        [HttpGet("GetAgreements")]
        public async Task<IActionResult> GetAgreements()
        {
            var agreements = await _agreementService.GetAllAgreementsAsync();
            return Ok(agreements);
        }
    }
}
