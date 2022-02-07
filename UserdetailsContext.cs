using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace UserApi.Models
{
    public class UserdetailsContext : DbContext
    {
        public UserdetailsContext(DbContextOptions<UserdetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Userdetails> Users { get; set; } = null!;
    }
}