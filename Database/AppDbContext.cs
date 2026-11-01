namespace GuardWallet.Database;
using Microsoft.EntityFrameworkCore;
using GuardWallet.Models;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=guard_wallet_app.db");
    }
        
}