using DomainDrivenDesignPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignPOC.Infrastructure.ApplicationDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Company> Company { get; set; }

    }
}
