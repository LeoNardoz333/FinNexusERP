using Microsoft.EntityFrameworkCore;
using FinNexus.Application.Common.Interfaces.Persistence;

namespace FinNexus.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}