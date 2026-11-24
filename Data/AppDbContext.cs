using Microsoft.EntityFrameworkCore;
using wt_lab12_12auth_validation_liseychikov.Models;

namespace wt_lab12_12auth_validation_liseychikov.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskModel> Tasks => Set<TaskModel>();

    public DbSet<User> Users=>Set<User>();
}