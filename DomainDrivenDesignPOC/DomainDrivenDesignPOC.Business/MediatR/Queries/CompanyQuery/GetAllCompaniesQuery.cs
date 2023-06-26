using DomainDrivenDesignPOC.Domain.Entities;
using MediatR;

namespace DomainDrivenDesignPOC.Business.MediatR.Queries.CompanyQuery
{
    public class GetAllCompaniesQuery : IRequest<IList<Company>>
    {
    }
}
