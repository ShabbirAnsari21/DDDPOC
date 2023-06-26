using DomainDrivenDesignPOC.Domain.Entities;
using DomainDrivenDesignPOC.Domain.Interfaces;
using DomainDrivenDesignPOC.Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignPOC.Infrastructure.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _appDbContext;
        public CompanyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IList<Company>> GetAllCompanyAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Company.ToListAsync();
        }
    }
}
