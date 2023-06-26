using DomainDrivenDesignPOC.Domain.Entities;

namespace DomainDrivenDesignPOC.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        Task<IList<Company>> GetAllCompanyAsync(CancellationToken cancellationToken);
    }
}
