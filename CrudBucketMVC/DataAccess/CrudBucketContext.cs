using Microsoft.EntityFrameworkCore;
using CrudBucketMVC.Models;

namespace CrudBucketMVC.DataAccess
{
    public class CrudBucketContext : DbContext
    {
        public DbSet<Town> Towns { get; set; }
        public DbSet<Hike> Hikes { get; set; }
        public CrudBucketContext(DbContextOptions<CrudBucketContext> options) : base(options)
        {
            
        }
    }
}
