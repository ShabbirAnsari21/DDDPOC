using System.ComponentModel.DataAnnotations;

namespace DomainDrivenDesignPOC.Api.Model.Request
{
    public record CompanyRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
