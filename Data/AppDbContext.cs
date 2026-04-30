using Microsoft.EntityFrameworkCore;

namespace Mind_Sentinel.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //5awal
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //5awal
            var constr = configuration.GetSection("constr").Value;
            //5awal
            optionsBuilder.UseSqlServer(constr);

        }
    }
}
