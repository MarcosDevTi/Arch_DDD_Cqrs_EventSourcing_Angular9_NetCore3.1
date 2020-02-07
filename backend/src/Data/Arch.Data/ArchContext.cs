using Arch.Domain;
using Microsoft.EntityFrameworkCore;

namespace Arch.Data
{
    public class ArchContext: DbContext
    {
        public ArchContext(DbContextOptions<ArchContext> options): base(options)
        {
            
        }

        public DbSet<Customer> Customers {get;set;}
        
    }
}