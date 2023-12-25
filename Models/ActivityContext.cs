using Microsoft.EntityFrameworkCore;

namespace RunnersApi.Models;

public class ActivityContext : DbContext
{
    public ActivityContext(DbContextOptions<ActivityContext> options) : base(options)
    {

    }

    public DbSet<Activity> Activities { get; set; } = null!;
}