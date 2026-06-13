using Microsoft.EntityFrameworkCore;
using STEMPilotAI.Core.Entities;

namespace STEMPilotAI.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Subject> Subjects { get; set; }
}