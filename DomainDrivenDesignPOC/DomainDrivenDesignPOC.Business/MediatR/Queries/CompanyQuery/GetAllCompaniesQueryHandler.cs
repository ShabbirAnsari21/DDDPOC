using DomainDrivenDesignPOC.Domain.Entities;
using DomainDrivenDesignPOC.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesignPOC.Business.MediatR.Queries.CompanyQuery
{
    public class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, IList<Company>>
    {
        private readonly ICompanyRepository _repository;
        public GetAllCompaniesQueryHandler(ICompanyRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IList<Company>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllCompanyAsync(cancellationToken);
        }
    }
}
