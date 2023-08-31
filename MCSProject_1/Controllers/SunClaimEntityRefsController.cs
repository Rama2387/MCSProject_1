using MCSProject_1.Interfaces;
using MCSProject_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCSProject_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SunClaimEntityRefsController : ControllerBase
    {
        private readonly IClaims<SunClaimEntityRef> _sunClaimEntityRefRepo;

        public SunClaimEntityRefsController(IClaims<SunClaimEntityRef> sunClaimEntityRefRepo)
        {
            _sunClaimEntityRefRepo = sunClaimEntityRefRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSunClaimEntityRef()
        {
            var allClaims = await _sunClaimEntityRefRepo.GetAll();
            return Ok(allClaims);
        }
        [HttpGet("GetClaimById/{claimId}")]
        public async Task<IActionResult> GetSunClaimEntityRefById(decimal claimId)
        {
            var claim = await _sunClaimEntityRefRepo.GetClaimById(claimId);
            return Ok(claim);
        }

    }
}
