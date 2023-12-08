using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class CardDbContext : DbContext
    {
        public CardDbContext (DbContextOptions<CardDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaseballCard> BaseballCards {get; set;}
        public DbSet<Owner> Owners {get; set;}
    }
}