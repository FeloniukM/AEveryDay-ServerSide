using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AEveryDayDbContext : IdentityDbContext<User>
    {
        public AEveryDayDbContext(DbContextOptions<AEveryDayDbContext> options) : base(options)
        {
             Database.EnsureCreated();
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}
