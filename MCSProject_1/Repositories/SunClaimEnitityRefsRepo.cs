using MCSProject_1.Interfaces;
using MCSProject_1.Models;
using Microsoft.EntityFrameworkCore;

namespace MCSProject_1.Repositories
{
    public class SunClaimEnitityRefsRepo : IClaims<SunClaimEntityRef>
    {
        private readonly MCS_DEVContext _dbContext;

        public SunClaimEnitityRefsRepo(MCS_DEVContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<SunClaimEntityRef>> GetAll()
        {
            return await _dbContext.SunClaimEntityRefs.ToListAsync();
        }

        public async Task<SunClaimEntityRef?> GetClaimById(decimal id)
        {
            var claim = await _dbContext.SunClaimEntityRefs.FirstOrDefaultAsync(u => u.DecClaimNumber == id);

           // var claim = await _dbContext.FindAsync<SunClaimEntityRef>(id);
            if(claim == null)
            {
                return null;
            }
            return claim;
        }
    }
}
