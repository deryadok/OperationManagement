using Microsoft.EntityFrameworkCore;
using Services.ActionType.Model.Model;

namespace Services.ActionType.Data.Context
{
    public class ActionTypeDbContext : DbContext
    {
        public DbSet<Model.Model.ActionType> ActionTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public ActionTypeDbContext(DbContextOptions<ActionTypeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}
