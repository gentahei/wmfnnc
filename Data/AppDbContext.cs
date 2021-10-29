using Microsoft.EntityFrameworkCore;
using Wmfnnc.Models;

namespace Wmfnnc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<m_dukcapil_data> m_dukcapil_data { get; set;}
        public DbSet<m_religion> m_religion { get; set;}
        public DbSet<m_marital_status> m_marital_status { get; set;}
        // public DbSet<t_dukcapil_check_result> Checks { get; set;}
    }
}