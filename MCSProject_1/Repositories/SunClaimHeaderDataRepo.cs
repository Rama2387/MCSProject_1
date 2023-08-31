using MCSProject_1.Interfaces;
using MCSProject_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MCSProject_1.Repositories
{
    public class SunClaimHeaderDataRepo : IClaims<SunClaimHeaderDatum>
    {
        private readonly MCS_DEVContext _context;

        public SunClaimHeaderDataRepo(MCS_DEVContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SunClaimHeaderDatum>> GetAll()
        {
           return await _context.SunClaimHeaderData.ToListAsync();
        }

        

        public async Task<SunClaimHeaderDatum?> GetClaimById(decimal id)
        {
            var claimHeader = await _context.SunClaimHeaderData.FirstOrDefaultAsync(h => h.DecClaimNumber == id);

            if(claimHeader == null)
            {
                return null;

            }
            return claimHeader;
            
        }
    }
}
