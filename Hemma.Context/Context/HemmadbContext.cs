using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace Hemma.Context.Context
{
    public class HemmadbContext : DbContext
    {
        public HemmadbContext(DbContextOptions<HemmadbContext> options) : base(options) { }

        public void ConfigurConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<HemmadbContext>(options =>
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["HemmDb"].ConnectionString));
        }

        public DbSet<Hemma.Context.ContextEntities.Person> Persons { get; set; }
    }
}
