using MCSProject_1.Interfaces;
using MCSProject_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCSProject_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SunClaimHeaderDataController : ControllerBase
    {
        private readonly IClaims<SunClaimHeaderDatum> _sunClaimHeaderDataRepo;

        public SunClaimHeaderDataController(IClaims<SunClaimHeaderDatum> sunClaimHeaderDataRepo)
        {
            _sunClaimHeaderDataRepo = sunClaimHeaderDataRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSunClaimHeaderData()
        {
            var allClaimsHeaders = await _sunClaimHeaderDataRepo.GetAll();
            return Ok(allClaimsHeaders);
        }
        [HttpGet("GetClaimHeaderById/{claimId}")]
        public async Task<IActionResult> GetSunClaimHeaderById(decimal claimId)
        {
            var claim = await _sunClaimHeaderDataRepo.GetClaimById(claimId);
            return Ok(claim);
        }

    }
}
