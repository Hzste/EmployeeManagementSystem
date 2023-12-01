using Microsoft.EntityFrameworkCore;

public class ManagementSystemContext : DbContext
{
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Employee> Employees { get; set; }

    private readonly string _connectionString = "Server=localhost;Database=management;User=root;Password=root";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        optionsBuilder.UseSnakeCaseNamingConvention();
    }
}