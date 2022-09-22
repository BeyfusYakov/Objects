using Microsoft.EntityFrameworkCore;

namespace Objects.Models
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext (DbContextOptions<UserContext> option): base(option)
        {
            Database.EnsureCreated();
        }
    }
}
