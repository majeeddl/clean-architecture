using Microsoft.EntityFrameworkCore;

namespace DotNetCleanTemplate.Persistence.Db
{
    public class CleanArchReadOnlyDbContext : AppDbContext
    {
        public CleanArchReadOnlyDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
