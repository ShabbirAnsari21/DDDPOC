using System.ComponentModel.DataAnnotations;

namespace DomainDrivenDesignPOC.Domain.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }

        private Company(string name)
        {
            Name = name;
        }
        public static Company Create(string name)
        {
            return new Company(name);
        }
        public void Update(string name)
        {
            Name = name;
        }
    }
}
