using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
    }
}
