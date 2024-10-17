using HMS_V1._0.Models;
using Microsoft.EntityFrameworkCore;
using HMS_V1._0.Models;
namespace HMS_V1._0.Data
{
    public class ApplicaitonDbContext : DbContext
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {

        }

        public DbSet<HMS_V1._0.Models.BookViewModel> BookViewModel { get; set; }

    }
}
