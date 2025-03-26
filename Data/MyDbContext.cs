using Microsoft.EntityFrameworkCore;

namespace TaskManager;
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        
    } 
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<List> Lists { get; set; }
}