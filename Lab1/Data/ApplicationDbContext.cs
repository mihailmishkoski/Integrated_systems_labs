using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab1.Models;

namespace Lab1.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lab1.Models.Concert> Concert { get; set; } = default!;
        public DbSet<Lab1.Models.Ticket> Ticket { get; set; } = default!;
    }
}
