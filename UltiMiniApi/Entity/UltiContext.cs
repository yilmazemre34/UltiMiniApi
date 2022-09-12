using Microsoft.EntityFrameworkCore;
using UltiMiniApi.Model;

namespace UltiMiniApi.Entity
{
    public class UltiContext : DbContext
    {
        public DbSet<Safe> Safe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Initial Catalog=UltiMiniDb;Persist Security Info=False;User ID=sa;Password=123;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
    
}
